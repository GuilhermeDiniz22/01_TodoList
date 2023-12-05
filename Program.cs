

var tarefas = new List<string>();

bool saida = false;

while(!saida)
{
    Console.WriteLine();
    Console.WriteLine("Bem vindo ao Listar Tarefas");
    Console.WriteLine( );
    Console.WriteLine("[V]er todas as tarefas");
    Console.WriteLine("[A]dicionar tarefa");
    Console.WriteLine("[E]ditar tarefa");
    Console.WriteLine("[R]emover tarefa");
    Console.WriteLine("[L]impar tela");
    Console.WriteLine("[S]air");
    Console.WriteLine();
    Console.WriteLine("Digite a letra correspondente para selecionar uma opção: ");
    var escolha = Console.ReadLine();

    switch (escolha)
    {
        case "S":
        case "s":
            saida = true;
            Console.WriteLine("Até Logo!");
            break;
        case "V":
        case "v":
            ListarTarefas();
            break;
        case "R":
        case "r":
            RemoverTarefa();
            break;
        case "A":
        case "a":
            AddTarefa();
            break;
        case "E":
        case "e":
            EditarTarefa();
            break;
        case "L":
        case "l":
            Console.Clear();
            break;
        default:
            Console.WriteLine("Escolha inválida.");
            break;
            
    }
}

void RemoverTarefa()
{
    bool TarefaValida = false;

    while (!TarefaValida)
    {
        Console.WriteLine("Entre a tarefa para remover: ");
        var TarefaRemover = Console.ReadLine().ToLower();

        if (string.IsNullOrWhiteSpace(TarefaRemover))
        {
            Console.WriteLine();
            TarefaVazia();
        }
        else if (tarefas.Contains(TarefaRemover))
        {
            TarefaValida = true;
            tarefas.Remove(TarefaRemover);
            Console.WriteLine();
            Console.WriteLine("Tarefa Removida com sucesso!");
        }
        else
        {
            Console.WriteLine("Tarefa não existe na lista de tarefas.");
        }
        
    }
}

void ListarTarefas()
{
    if(tarefas.Count == 0)
    {
        Console.WriteLine();
        Console.WriteLine("Nenhuma tarefa na lista.");
    }

    for(int i = 0; i < tarefas.Count; i++)
    {
        Console.WriteLine();
        Console.WriteLine($"Tarefa {i + 1}: {tarefas[i]}");
    }
}

void AddTarefa()
{  
    bool TarefaValida = false;

    while (!TarefaValida)
    {
        Console.WriteLine("Entre a nova tarefa: ");
        var novaTarefa = Console.ReadLine().ToLower();

        if (string.IsNullOrWhiteSpace(novaTarefa))
        {
            Console.WriteLine();
            TarefaVazia();
        }
        else if (tarefas.Contains(novaTarefa))
        {
            Console.WriteLine();
            Console.WriteLine("Tarefa já existe na lista de tarefas.");
            continue;
        }
        else
        {
            TarefaValida = true;
            tarefas.Add(novaTarefa);
            Console.WriteLine();
            Console.WriteLine("Tarefa Adicionada com sucesso!");
        }
    }       
}

void EditarTarefa()
{
    bool TarefaValida = false;

    while (!TarefaValida)
    {
        Console.WriteLine();
        Console.WriteLine("Escolha a tarefa para editar: ");
        var TarefaEscolhida = Console.ReadLine().ToLower();

        if (string.IsNullOrWhiteSpace(TarefaEscolhida))
        {
            Console.WriteLine();
            TarefaVazia();
        }
        
        else if (!tarefas.Contains(TarefaEscolhida))
        {
            Console.WriteLine("Tarefa não encontrada");
            continue;
        }
        else
        {
            for (int i = 0; i < tarefas.Count; i++)
            {
                if (tarefas[i] == TarefaEscolhida)
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite uma nova tarefa para substituir a escolhida: ");
                    var TarefaEditada = Console.ReadLine().ToLower();

                    tarefas[i] = TarefaEditada;

                    TarefaValida = true;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tarefa Editada com sucesso!");
        }
    }
}


static void TarefaVazia()
{
    Console.WriteLine("A tarefa não pode ser vazia.");
}





