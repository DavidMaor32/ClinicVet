using ClinicVet.Gui.Pages.Pet;

// ==****  עוד לא סיימתי עם הטופס הזה ואולי הוא ימחק , נשאר לממש פונקציונליות ולטל ב LIST BOX

namespace ClinicVet.Gui.Pages.PetCatalog;

public partial class PetCatalogForm : Form
{
    public PetCatalogForm()
    {
        InitializeComponent();
    }

    private void backBtn_Click(object sender, EventArgs e)
    {

        this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        PetForm petForm = new PetForm();
        petForm.ShowDialog();
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }
}
