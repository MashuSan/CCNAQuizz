using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CNAAPrograme
{
    public partial class CCNAForms : Form
    {
        private List<Question> _questions;
        private int position = 0;
        private int score;

        public CCNAForms(int version)
        {
            InitializeComponent();

            if (version == 1) _questions = QuestionSet.CCNA1Questions();
            if (version == 2) _questions = QuestionSet.CCNA2Questions();
            if (version == 3) _questions = QuestionSet.CCNA3Questions();

            _question.MaximumSize = new Size(this.Width - 20, 0);
            _question.AutoSize = true;

            addData();
        }

        private void _evaluateButton_Click(object sender, EventArgs e)
        {
            var checkedButton = panel1.Controls.OfType<CheckBox>()
                                      .Where(r => r.Checked).Select(x => x.Text);

            var checkedAnswers = String.Join(",", checkedButton);

            if (!checkedButton.Any())
            {
                MessageBox.Show("VYBER ODPOVED");
                return;
            }

            if (_questions[position].RightAnswer == checkedAnswers)
            {
                score += 1;
            }

            position++;

            if (position >= _questions.Count)
            {
                MessageBox.Show("Dosiahli ste skóre :" + score + "/" + _questions.Count);
                this.Close();
                return;
            }

            addData();
        }

        private void addData()
        {
            _question.Text = _questions[position].QuestionData;
            addAnswers(_questions[position].Answers);
        }

        private void addAnswers(List<string> answers)
        {
            panel1.Controls.Clear();

            foreach (var a in answers)
            {
                var temp = new CheckBox();
                temp.Text = a;
                temp.MaximumSize = new Size(this.Width - 20, 0);
                temp.AutoSize = true;

                panel1.Controls.Add(temp);
            }

        }
    }
}
