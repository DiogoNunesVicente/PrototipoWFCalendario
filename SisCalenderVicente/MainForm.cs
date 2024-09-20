using Microsoft.EntityFrameworkCore;
using SisCalenderVicente.Data;

namespace PrototipoCalendario
{
    public partial class MainForm : Form
    {
        private DateTime currentDate;
        private Panel calendarPanel;
        private Button prevMonthButton;
        private Button nextMonthButton;
        private Label currentDateLabel;
        private List<DateTime> agendamentos;

        public MainForm()
        {
            InitializeComponent();
            InitializeComponent2();
            CriarBancoDeDados();
            currentDate = DateTime.Today;
            RenderCalendar(currentDate);
        }

        private void CriarBancoDeDados()
        {
            using (var Banco = new AppDbContext())
            {
                Banco.Database.Migrate();
            }
        }

        private void InitializeComponent2()
        {
            this.Text = "Calendário";
            this.Size = new Size(400, 450);

            agendamentos = new List<DateTime>
        {
            new DateTime(DateTime.Today.Year, DateTime.Today.Month, 5),
            new DateTime(DateTime.Today.Year, DateTime.Today.Month, 12),
            new DateTime(DateTime.Today.Year, DateTime.Today.Month, 20)
        };

            prevMonthButton = new Button
            {
                Text = "Anterior",
                Location = new Point(10, 10),
                Size = new Size(75, 30)
            };
            prevMonthButton.Click += PrevMonthButton_Click;

            nextMonthButton = new Button
            {
                Text = "Próximo",
                Location = new Point(300, 10),
                Size = new Size(75, 30)
            };
            nextMonthButton.Click += NextMonthButton_Click;
            currentDateLabel = new Label

            {
                Text = currentDate.ToString("MMMM yyyy"),
                Location = new Point(130, 15),
                Size = new Size(140, 20),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            calendarPanel = new Panel
            {
                Location = new Point(10, 50),
                Size = new Size(360, 360)
            };

            this.Controls.Add(prevMonthButton);
            this.Controls.Add(nextMonthButton);
            this.Controls.Add(currentDateLabel);
            this.Controls.Add(calendarPanel);
        }
        private void RenderCalendar(DateTime date)
        {
            calendarPanel.Controls.Clear();
            currentDateLabel.Text = date.ToString("MMMM yyyy");

            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            int startDayOfWeek = (int)firstDayOfMonth.DayOfWeek;
            int panelSize = 50;

            for (int i = 0; i < daysInMonth; i++)
            {
                Panel dayPanel = new Panel
                {
                    Size = new Size(panelSize, panelSize),
                    Location = new Point((startDayOfWeek + i) % 7 * panelSize, (startDayOfWeek + i) / 7 * panelSize),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                DateTime currentDay = new DateTime(date.Year, date.Month, i + 1);

                Button dayButton = new Button
                {
                    Text = (i + 1).ToString(),
                    Size = new Size(panelSize, panelSize),
                    Tag = currentDay,
                    FlatStyle = FlatStyle.Flat
                };

                // Verifica se a data está na lista de agendamentos
                if (agendamentos.Contains(currentDay))
                {
                    dayButton.BackColor = Color.Yellow;
                }

                dayButton.Click += DayButton_Click;
                dayPanel.Controls.Add(dayButton);
                calendarPanel.Controls.Add(dayPanel);
            }
        }

        private void DayButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is DateTime selectedDate)
            {
                new FrmCadAgenda(selectedDate).ShowDialog();
            }
        }

        private void PrevMonthButton_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            RenderCalendar(currentDate);
        }
        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            RenderCalendar(currentDate);
        }
    }
}
