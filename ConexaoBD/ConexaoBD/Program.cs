using MySql.Data.MySqlClient;

Console.WriteLine("TESTE DE CONEXÃO E EDIÇÃO DE BD \n");

try
{
    //Conectando projeto ao banco de dados
    var strConexao = ("server=localhost;uid=root;pwd=root;database=db_crudContatos");
    var conexao = new MySqlConnection(strConexao);
    conexao.Open();

    //Mensagem de confirmação em caso de sucesso
    Console.WriteLine("Database connected! \n");

    //COMANDOS MYSQL

    //Pergunta e recebe o comando MySQL
    Console.WriteLine("Digite aqui o comando SQL: ");
    var comandoMySQL = Console.ReadLine().ToUpper();

    var comando = new MySqlCommand(comandoMySQL, conexao);
    var reader = comando.ExecuteReader();

    //Loop de mapeamento do banco de acordo com o comando
    while (reader.Read())
    {
        Console.WriteLine($"{reader["id_contato"]} | {reader["nm_nome"]} | {reader["cd_telefone"]} | {reader["cd_ativo"]}");
    }
    
}
catch (Exception error)
{
    //Mensagem em caso de erro
    Console.WriteLine("Database error: \n" + error.Message);
}

