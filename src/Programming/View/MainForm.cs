using Programming.View.Controls;
using System.Windows.Forms;

namespace Programming.View
{
    /// <summary>
    /// Наследуется от класса Form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            SeasonHandleControl.SeasonChanged += SeasonHandleControl_SeasonChanged;
        }

        public void SeasonHandleControl_SeasonChanged(object sender, ColorSelectedEventArgs args)
        {
            BackColor = args.Color;
        }
    }
}