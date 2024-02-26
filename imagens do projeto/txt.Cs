    string email = txtusuario.Text;
    string senha = txtSenha.Text;

    using (var conexao = new ConexaoComMySQL())
    {
        conexao.AbrirConexao();

        // Verificar na tabela Usuarios
        using (var comando = new MySqlCommand("SELECT * FROM Usuario WHERE Email = @Email AND Senha = @Senha", conexao.GetConexao()))
        {
            comando.Parameters.AddWithValue("@Email", Usuario);
            comando.Parameters.AddWithValue("@Senha", senha);

            using (var leitor = comando.ExecuteReader())
            {
                if (leitor.HasRows)
                {


                    // Se as credenciais estiverem corretas, navega para a próxima página
                    PainelAdmnistrativo painel = new PainelAdmnistrativo();
                    NavigationWindow window = new NavigationWindow();
                    window.Content = painel;
                    window.Show();
                    this.Close(); // Fecha a janela de login
                }
            }
        }
    }

    // Se chegamos até aqui, significa que as credenciais não foram encontradas em nenhuma das tabelas
    MessageBox.Show("usuario ou senha inválidos.");
}