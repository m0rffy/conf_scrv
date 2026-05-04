using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Uetm_2_0
{
    public class RoundedButton : Button
    {
        private int _borderRadius = 11;
        private Color _borderColor = Color.Black;
        private float _borderWidth = 1f;

        private Color _normalBackColor = Color.SkyBlue;
        private Color _hoverBackColor = Color.LightBlue;

        private bool _isHovered = false;

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
                MouseLeave += (s, e) => { _isHovered = false; Invalidate(); };
                this.HandleCreated += (s, e) => Invalidate();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent) { }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Color currentBack = _isHovered ? _hoverBackColor : _normalBackColor;
            Color parentBack = GetActualParentBackColor();

            // 1. Заливаем всё родительским цветом (скрываем любые «углы»)
            using (SolidBrush br = new SolidBrush(parentBack))
                g.FillRectangle(br, ClientRectangle);

            // 2. Чёрная рамка — внешний закруглённый прямоугольник
            using (GraphicsPath outerPath = GetRoundedPath(ClientRectangle, _borderRadius))
            using (SolidBrush borderBrush = new SolidBrush(_borderColor))
                g.FillPath(borderBrush, outerPath);

            // 3. Внутренний фон (отступ на толщину рамки)
            float inset = _borderWidth;
            Rectangle innerRect = new Rectangle(
                (int)(ClientRectangle.X + inset),
                (int)(ClientRectangle.Y + inset),
                (int)(ClientRectangle.Width - 2 * inset),
                (int)(ClientRectangle.Height - 2 * inset)
            );
            int innerRadius = Math.Max(0, _borderRadius - (int)inset);
            using (GraphicsPath innerPath = GetRoundedPath(innerRect, innerRadius))
            using (SolidBrush fillBrush = new SolidBrush(currentBack))
                g.FillPath(fillBrush, innerPath);

            // 4. Текст без фона
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                using (SolidBrush textBrush = new SolidBrush(ForeColor))
                    g.DrawString(Text, Font, textBrush, ClientRectangle, sf);
            }
        }

        /// <summary>
        /// Получает реальный цвет фона родителя, рекурсивно поднимаясь вверх,
        /// если у родителя указан Transparent.
        /// </summary>
        private Color GetActualParentBackColor()
        {
            Control parent = this.Parent;
            while (parent != null)
            {
                if (parent.BackColor != Color.Transparent)
                    return parent.BackColor;
                parent = parent.Parent;
            }
            return SystemColors.Control;
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}