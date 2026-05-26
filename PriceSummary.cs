using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using team3.Data.Models;

namespace team3
{
    public partial class PriceSummary : Form
    {
        private readonly Visit visit;

        public PriceSummary(Visit visit)
        {
            InitializeComponent();
            this.visit = visit;
            ShowSummary();
        }

        private void ShowSummary()
        {
            visitLabel.Text = $"Visit Price: {Visit.BASE_PRICE}";
            medNum.Text = visit.MedicinesPrice.ToString();
            totalNum.Text = visit.TotalPrice.ToString();

            MedListBox.Items.Clear();

            foreach (PrescribedMedicine medicine in visit.PrescribedMedicines)
            {
                MedListBox.Items.Add($"{medicine.MedicineName} x{medicine.Quantity} = {medicine.TotalPrice}");
            }
        }
    }
}