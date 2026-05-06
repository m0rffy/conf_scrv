using System.Drawing.Drawing2D;

namespace Uetm_2_0
{
    public class RoundedButton : Button
    {
        private int _borderRadius = 11;
        private Color _borderColor = Color.Black;
        private float _borderWidth = 1f;

        private readonly Color _normalBackColor = Color.SkyBlue;
        private readonly Color _hoverBackColor = Color.SteelBlue;
        private Color _pressedBackColor = Color.DeepSkyBlue;

        private bool _isHovered = false;
        private bool _isPressed = false;

        // Сдвиг текста (эффект вдавливания) – теперь включён по умолчанию
        private bool _textShiftOnPress = true;
        private int _textShiftAmount = 1;        // сдвиг при нажатии
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public float BorderWidth
        {
            get => _borderWidth;
            set { _borderWidth = value; Invalidate(); }
        }

        public bool TextShiftOnPress
        {
            get => _textShiftOnPress;
            set { _textShiftOnPress = value; Invalidate(); }
        }

        public int TextShiftAmount
        {
            get => _textShiftAmount;
            set { _textShiftAmount = value; Invalidate(); }
        }

        public Color PressedBackColor
        {
            get => _pressedBackColor;
            set { _pressedBackColor = value; Invalidate(); }
        }

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;

            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.SupportsTransparentBackColor, true);

            SetStyle(ControlStyles.Selectable, false);
            TabStop = false;
            DoubleBuffered = true;

            if (!DesignMode)
            {
                MouseEnter += (s, e) => { _isHovered = true; Invalidate(); };
                MouseLeave += (s, e) => { _isHovered = false; _isPressed = false; Invalidate(); };
                MouseDown += (s, e) => { _isPressed = true; Invalidate(); };
                MouseUp += (s, e) =>
                {
                    _isPressed = false;
                    _isHovered = ClientRectangle.Contains(PointToClient(MousePosition));
                    Invalidate();
                };
                HandleCreated += (s, e) => Invalidate();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent) { }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Color currentBack = _isPressed ? _pressedBackColor : _isHovered ? _hoverBackColor : _normalBackColor;
            Color parentBack = GetActualParentBackColor();

            // 1. Заливка родительским цветом
            using (SolidBrush br = new(parentBack))
            {
                g.FillRectangle(br, ClientRectangle);
            }

            // 2. Чёрная рамка
            using (GraphicsPath outerPath = GetRoundedPath(ClientRectangle, _borderRadius))
            using (SolidBrush borderBrush = new(_borderColor))
            {
                g.FillPath(borderBrush, outerPath);
            }

            // 3. Внутренний фон
            float inset = _borderWidth;
            Rectangle innerRect = new(
                (int)(ClientRectangle.X + inset),
                (int)(ClientRectangle.Y + inset),
                (int)(ClientRectangle.Width - (2 * inset)),
                (int)(ClientRectangle.Height - (2 * inset))
            );
            int innerRadius = Math.Max(0, _borderRadius - (int)inset);
            using (GraphicsPath innerPath = GetRoundedPath(innerRect, innerRadius))
            using (SolidBrush fillBrush = new(currentBack))
            {
                g.FillPath(fillBrush, innerPath);
            }

            // 4. Текст с возможным сдвигом при нажатии
            Rectangle textRect = ClientRectangle;
            if (_isPressed && _textShiftOnPress)
            {
                textRect.X += _textShiftAmount;
                textRect.Y += _textShiftAmount;
            }

            using StringFormat sf = new();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            using SolidBrush textBrush = new(ForeColor);
            g.DrawString(Text, Font, textBrush, textRect, sf);
        }

        private Color GetActualParentBackColor()
        {
            Control parent = Parent;
            while (parent != null)
            {
                if (parent.BackColor != Color.Transparent)
                {
                    return parent.BackColor;
                }

                parent = parent.Parent;
            }
            return SystemColors.Control;
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}