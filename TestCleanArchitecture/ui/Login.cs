using System;
using System.Collections.Generic;
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
            List<TodoResponse> todo = await todoUsecase.getTodo<TodoResponse>();
            Console.WriteLine(todo[0].title + "," + todo[0].completed);
        }
    }
}
