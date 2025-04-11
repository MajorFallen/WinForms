using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Lab02
{
    public partial class VialControl : UserControl
    {
        private int maxSegments = 4;
        private int initSegmentCount = 0;
        private List<Color> segments = new List<Color>();

        public VialControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        [Category("Vial Settings")]
        [Description("Maximum number of segments in the vial.")]
        public int MaxSegments
        {
            get => maxSegments;
            set
            {
                maxSegments = Math.Max(1, value); // zapobiega wartości 0
                Invalidate(); // przerysowanie
            }
        }

        [Category("Vial Settings")]
        [Description("Initial number of segments filled in the vial. Ignored if Segments is set manually.")]
        public int InitSegmentCount
        {
            get => initSegmentCount;
            set
            {
                initSegmentCount = Math.Min(value, MaxSegments);
                GenerateDefaultSegments();
                Invalidate();
            }
        }

        [Category("Vial Settings")]
        [Description("Custom list of color segments in the vial. Overrides InitSegmentCount.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Color> Segments
        {
            get => segments;
            set
            {
                segments = value ?? new List<Color>();
                maxSegments = Math.Max(maxSegments, segments.Count);
                Invalidate();
            }
        }

        private void GenerateDefaultSegments()
        {
            segments = new List<Color>();
            Random rand = new Random();
            for (int i = 0; i < initSegmentCount; i++)
            {
                segments.Add(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
            }
        }
    }
}
