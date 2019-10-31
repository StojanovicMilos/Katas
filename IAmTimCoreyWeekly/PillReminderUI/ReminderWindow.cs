using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PillReminderUI
{
    public partial class ReminderWindow : Form
    {
        private readonly BindingList<PillModel> _medications = new BindingList<PillModel>();

        public ReminderWindow()
        {
            InitializeComponent();
            allPillsListBox.DataSource = _medications;
            allPillsListBox.DisplayMember = nameof(PillModel.PillInfo);
            pillsToTakeListBox.DisplayMember = nameof(PillModel.PillInfo);
            PopulateDummyData();
            RefreshPillsToTake();
        }

        private void PopulateDummyData()
        {
            _medications.Add(new PillModel(pillName: "The white one", timeToTake: DateTime.ParseExact("0:15 am", "h:mm tt", null, System.Globalization.DateTimeStyles.AssumeLocal), lastTaken: DateTime.MinValue));
            _medications.Add(new PillModel(pillName: "The big one", timeToTake: DateTime.Parse("8:00 am"), lastTaken: DateTime.MinValue));
            _medications.Add(new PillModel(pillName: "The red ones", timeToTake: DateTime.Parse("11:45 pm"), lastTaken: DateTime.MinValue));
            _medications.Add(new PillModel(pillName: "The oval one", timeToTake: DateTime.Parse("0:27 am"), lastTaken: DateTime.MinValue));
            _medications.Add(new PillModel(pillName: "The round ones", timeToTake: DateTime.Parse("6:15 pm"), lastTaken: DateTime.MinValue));
        }

        private void RefreshPillsToTake_Click(object sender, EventArgs e) => RefreshPillsToTake();

        private void RefreshPillsToTake() =>
            pillsToTakeListBox.DataSource = new BindingList<PillModel>(
                _medications
                    .Where(m => m.PillShouldBeTakenBy(DateTime.Now))
                    .OrderBy(m => m.TimeToTake.TimeOfDay)
                    .ToList()
            );

        private void TakePill_Click(object sender, EventArgs e)
        {
            PillModel pillToTake = (PillModel) pillsToTakeListBox.SelectedItem;
            pillToTake?.TakePillAt(DateTime.Now);
            RefreshPillsToTake();
        }

        private void Timer1_Tick(object sender, EventArgs e) => RefreshPillsToTake();
    }
}
