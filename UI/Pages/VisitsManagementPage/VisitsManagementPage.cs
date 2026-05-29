using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicVet.Data.Models;
using ClinicVet.Data.Repositories;

namespace ClinicVet.UI.Pages.VisitsManagementPage
{
    public partial class VisitsManagementPage : Form
    {
        private readonly VisitsRepository visitsRepository;

        public VisitsManagementPage(VisitsRepository visitsRepository)
        {
            InitializeComponent();

            this.visitsRepository = visitsRepository;

            SetupGrid();
            LoadVisits();
        }

        private void SetupGrid()
        {
            visitsGridView.ReadOnly = true;
            visitsGridView.AllowUserToAddRows = false;
            visitsGridView.AllowUserToDeleteRows = false;
            visitsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            visitsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadVisits()
        {
            List<Visit> visits = visitsRepository.GetAll();

            visitsGridView.DataSource = visits.Select(visit => new
            {
                VisitId = visit._Id,
                AnimalId = visit.AnimalId,
                Reason = visit.Reason,
                DateTime = visit.DateTime,
                Diagnosis = visit.Diagnosis,
                VetWorkerId = visit.VetWorkerId,
                Prescriptions = visit.PrescribedMedicinesJson
            }).ToList();
        }
    }
}
