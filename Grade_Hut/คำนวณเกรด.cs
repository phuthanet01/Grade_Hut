using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Hut
{
    public partial class คำนวณเกรด : Form
    {
        public คำนวณเกรด()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // อ่านคะแนนจาก TextBox
            if (int.TryParse(txtScore.Text, out int score))
            {
                // คำนวณเกรด
                string grade;
                if (score >100)
                    grade = "S+ เลยไหมคะแนนเกิน 100 แล้ว";
                else if (score >= 80 && score <= 100)
                    grade = "A";
                else if (score >= 75 && score <= 79)
                    grade = "B+";
                else if (score >= 70 && score <= 74)
                    grade = "B";
                else if (score >= 65 && score <= 69)
                    grade = "C+";
                else if (score >= 60 && score <= 64)
                    grade = "D";
                else if (score >= 55 && score <= 59)
                    grade = "D";
                else if (score >= 50 && score <= 54)
                    grade = "D";
                else
                    grade = "F";

                // แสดงผลลัพธ์ใน MessageBox
                MessageBox.Show($"คะแนน {score} คะแนน ได้เกรด {grade}", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("โปรดกรอกข้อมูลที่ถูกต้องให้ครบถ้วน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
