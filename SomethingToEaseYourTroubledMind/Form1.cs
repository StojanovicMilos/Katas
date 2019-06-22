using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SomethingToEaseYourTroubledMind
{
    //motivated by https://9gag.com/gag/aYYXPQ7
    public partial class Form1 : Form
    {
        private MovingDots _movingDots;
        private readonly Pen _pen = new Pen(Color.Red);
        private readonly SolidBrush _brush = new SolidBrush(Color.Red);
        private readonly Graphics _graphics;

        public Form1()
        {
            InitializeComponent();
            _graphics = pictureBox1.CreateGraphics();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int numberOfDots = Convert.ToInt32(numericUpDown1.Value);
            _movingDots = new MovingDots(numberOfDots, Math.Min(pictureBox1.Width / 2 - 10, pictureBox1.Height / 2 - 10));
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _movingDots.UpdatePositions();
            DrawDots(_movingDots);
        }

        private void DrawDots(MovingDots movingDots)
        {
            Point[] currentPositions = movingDots.GetCurrentPositions();

            pictureBox1.Refresh();
            for (int i = 0; i < currentPositions.Length; i++)
            {
                Point currentPosition = currentPositions[i];
                _graphics.FillEllipse(_brush, currentPosition.X - 5, currentPosition.Y - 5, 10, 10);
                if (i < currentPositions.Length - 1)
                {
                    Point nextPosition = currentPositions[i + 1];
                    _graphics.DrawLine(_pen, currentPosition, nextPosition);
                }
            }
        }
    }

    public class MovingDots
    {
        private readonly MovingDot[] _movingDots;

        public MovingDots(int numberOfDots, int maxCircleRadius)
        {
            _movingDots = new MovingDot[numberOfDots];
            for (int i = 0; i < numberOfDots; i++)
            {
                int thisCircleRadius = (i + 1) * maxCircleRadius / numberOfDots;
                _movingDots[i] = new MovingDot(thisCircleRadius, numberOfDots - i, maxCircleRadius);
            }
        }

        public void UpdatePositions()
        {
            foreach (var movingDot in _movingDots)
            {
                movingDot.UpdatePosition();
            }
        }

        public Point[] GetCurrentPositions() => _movingDots.Select(m => m.CurrentPosition).ToArray();
    }

    public class MovingDot
    {
        private readonly int _thisCircleRadius;
        private readonly double _speed;
        private readonly int _maxCircleRadius;
        private double _angle;

        public Point CurrentPosition { get; private set; }

        public MovingDot(int thisCircleRadius , double speed, int maxCircleRadius)
        {
            _thisCircleRadius = thisCircleRadius;
            _speed = speed;
            _maxCircleRadius = maxCircleRadius;
            _angle = 0;
        }

        public void UpdatePosition()
        {
            CurrentPosition = new Point((int) (_thisCircleRadius * Math.Cos(_angle)) + _maxCircleRadius, (int) (_thisCircleRadius * Math.Sin(_angle)) + _maxCircleRadius);
            _angle = _angle + _speed * Math.PI / 180.0;
        }
    }
}
