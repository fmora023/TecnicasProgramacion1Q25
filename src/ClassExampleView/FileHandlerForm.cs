using ClassExampleController;
using ClassExampleController.FileHandle;
using ClassExampleModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassExample
{
    /// <summary>
    /// Form in charge of handling the file operations.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FileHandlerForm : Form
    {
        private readonly DataAccessManager dataAccessManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileHandlerForm"/> class.
        /// </summary>
        public FileHandlerForm()
        {
            InitializeComponent();
            this.dataAccessManager = new DataAccessManager(new FileHandler());
        }

        private void btn_CreateRegisters_Click(object sender, EventArgs e)
        {
            var path = this.txt_FilePath.Text;
            var peopleRequired = int.Parse(this.txt_RequiredPeople.Text);

            var people = this.dataAccessManager.GenerateFileAndPeople(peopleRequired, path);

            if (people != null && people.Any())
            {
                MessageBox.Show("File created successfully");
            }
            else
            {
                MessageBox.Show("An error occurred while creating the file");
            }
        }

        private void btn_AddRegister_Click(object sender, EventArgs e)
        {
            var person = new Student()
            {
                Name = "Juan",
                LastName = "Diaz Perez",
                Age = 25
            };

            var path = this.txt_FilePath.Text;
            var result = this.dataAccessManager.Add(person, path);

            if (result)
            {
                MessageBox.Show("Person added successfully");
            }
            else
            {
                MessageBox.Show("An error occurred while adding the person");
            }
        }
    }
}
