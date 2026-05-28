using ClinicVet.Data.Models;

namespace ClinicVet.UI.Pages.PriceSummary;

public partial class PriceSummaryPage : Form {
    private readonly Visit visit;

    public PriceSummaryPage(Visit visit) {
        InitializeComponent();
        this.visit = visit;
        ShowSummary();
    }

    private void ShowSummary() {
        visitLabel.Text = $"Visit Price: {Visit.BASE_PRICE}";
        medNum.Text = visit.MedicinesPrice.ToString();
        totalNum.Text = visit.TotalPrice.ToString();

        MedListBox.Items.Clear();

        foreach (PrescribedMedicine medicine in visit.PrescribedMedicines) {
            MedListBox.Items.Add($"{medicine.MedicineName} x{medicine.Quantity} = {medicine.TotalPrice}");
        }
    }
}