﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Iteration1

{
    public partial class Attendance : Form
    {

        public Attendance()
        {

            InitializeComponent();
            LoadAttendance();

            //DisplayAttendance();
        }
        private void LoadAttendance()
        {
            dataGridView1.DataSource = ReadAttendanceDataFromExcel("Attendance.xlsx");
            dataGridView2.DataSource = ReadAttendanceDataFromExcel("Attendance.xlsx");
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
        }

        private DataTable ReadAttendanceDataFromExcel(string filePath)
        {
            DataTable dataTable = new DataTable();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                Console.WriteLine($"Number of Worksheets: {package.Workbook.Worksheets.Count}");
                // Assuming your workbook always has at least one worksheet
                if (package.Workbook.Worksheets.Any())
                {
                    var worksheet = package.Workbook.Worksheets.First();

                    Console.WriteLine($"Worksheet Name: {worksheet.Name}");


                    // Add columns to the DataTable based on your Excel file structure
                    for (int col = worksheet.Dimension.Start.Column; col <= worksheet.Dimension.End.Column; col++)
                    {
                        dataTable.Columns.Add(worksheet.Cells[1, col].Text, typeof(string));
                    }

                    // Add rows to the DataTable based on your Excel file data
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        DataRow dataRow = dataTable.NewRow();

                        for (int col = worksheet.Dimension.Start.Column; col <= worksheet.Dimension.End.Column; col++)
                        {
                            dataRow[col - 1] = worksheet.Cells[row, col].Text;
                        }

                        dataTable.Rows.Add(dataRow);
                    }
                }
                else
                {
                    // Handle the case where there are no worksheets in the workbook
                    MessageBox.Show("No worksheets found in the Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dataTable;
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Annoucement1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            Visible = false;
        }

        private void Annoucement_bttn_Click(object sender, EventArgs e)
        {
            Annoucement annoucementpage = new Annoucement();
            annoucementpage.Show();
            Visible = false;
        }

        private void Assignment_bttn_Click(object sender, EventArgs e)
        {
            Assignment assignmentpage = new Assignment();
            assignmentpage.Show();
            Visible = false;
        }

        private void Resource_bttn_Click(object sender, EventArgs e)
        {
            Resource resourcepage = new Resource();
            resourcepage.Show();
            Visible = false;
        }

        private void Marks_bttn_Click(object sender, EventArgs e)
        {
            Marks markspage = new Marks();
            markspage.Show();
            Visible = false;
        }

        private void Chat_bttn_Click(object sender, EventArgs e)
        {
            Chat chatpage = new Chat();
            chatpage.Show();
            Visible = false;
        }

        private void Logoutbttn_Click(object sender, EventArgs e)
        {
            Login logpage = new Login();
            logpage.Show();
            Visible = false;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
