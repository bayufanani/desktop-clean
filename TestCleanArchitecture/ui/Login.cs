using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCleanArchitecture.data.source.remote.response.todo;
using TestCleanArchitecture.domain.usecase;

namespace TestCleanArchitecture
{
    public partial class Login : Form
    {
        TodoUsecase todoUsecase;
        public Login(TodoUsecase todoUsecase)
        {
            InitializeComponent();
            this.todoUsecase = todoUsecase;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            TodoResponse todo = await todoUsecase.getTodo();
            Console.WriteLine(todo.ToString());
        }
    }
}
