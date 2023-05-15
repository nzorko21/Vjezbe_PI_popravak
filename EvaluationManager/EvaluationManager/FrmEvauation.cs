using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel; 
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager {
    public partial class FrmEvauation : Form {
        private Student student;

        public Student SelectedStudent { get => student; set => student = value; }

        public FrmEvauation(Student selectedStudent) {
            InitializeComponent();
            student = selectedStudent;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void FrmEvauation_Load(object sender, EventArgs e) {
            SetFormText();
            var activities = ActivityRepository.GetActivities();
            cboActivities.DataSource = activities;

        }
        private void SetFormText() {
            Text = student.FirstName + " " + student.LastName;
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e) {
            var currentActivity = cboActivities.SelectedItem as Activity;
            txtActivityDescription.Text = currentActivity.Description;
            txtMinForGrade.Text = currentActivity.MinPointsForGrade + "/" + currentActivity.MaxPoints;
            txtMinForSignature.Text = currentActivity.MinPointsForSignature + "/" + currentActivity.MaxPoints;
            numPoints.Minimum = 0;
            numPoints.Maximum = currentActivity.MaxPoints;

            var evaluation = EvaluationRepository.GetEvaluation(SelectedStudent, currentActivity);
            if(evaluation!= null) {
                txtTeacher.Text = evaluation.Evalutaor.ToString();
                txtEvaluationDate.Text=evaluation.EvaluationaDate.ToString();
                numPoints.Value= evaluation.Points;
            } else {

                txtTeacher.Text= FrmLogin.LoggedTeacher.ToString();
                txtEvaluationDate.Text = "-";
                numPoints.Value = 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
