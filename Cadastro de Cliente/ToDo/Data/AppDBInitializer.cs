using ToDo.Models;

namespace ToDo.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                //Criar tarefas se estiver vazia
                if (!context.Tarefas.Any())
                {
                    context.Tarefas.AddRange(new List<Tarefa>()
                    {

                        new Tarefa()
                        {
                            Name = "Thiago Campos",
                            Telefone = "(16) 98863-0184",
                            Email = "Thiago-kono@hotmail.com",
                            End_Completo = "Rua da Liberdade, 222, Bairro Independência",
                            EndDate = DateTime.Now.AddDays(450),
                            Status = false
                        },

                        new Tarefa()
                        {
                            Name = "Maria da Silva",
                            Telefone = "(11) 91234-5678",
                            Email = "maria.silva@email.com",
                            End_Completo = "Rua das Flores, 123, Bairro Jardim Primavera",
                            EndDate = DateTime.Now.AddDays(130),
                            Status = false
                        },

                        new Tarefa()
                        {
                            Name = "João Santos",
                            Telefone = "(21) 98176-5432",
                            Email = "joao.santos@email.com",
                            End_Completo = "Avenida Central, 456, Bairro Centro",
                            EndDate = DateTime.Now.AddDays(7),
                            Status = false
                        },
                        new Tarefa()
                        {
                            Name = "Ana Oliveira",
                            Telefone = "(47) 98866-5355",
                            Email = "ana.oliveira@email.com",
                            End_Completo = "Rua da Praia, 789, Bairro Beira Mar",
                            EndDate = DateTime.Now.AddDays(-510),
                            Status = false
                        },
                        new Tarefa()
                        {
                            Name = "Carlos Pereira",
                            Telefone = "(31) 98765-4321",
                            Email = "carlos.pereira@email.com",
                            End_Completo = "Rua das Árvores, 1010, Bairro Verdejante",
                            EndDate = DateTime.Now.AddDays(12),
                            Status = false
                        },

                        new Tarefa()
                        {
                            Name = "Paulo Mendes",
                            Telefone = "(99) 98826-5352",
                            Email = "paulo.mendes@email.com",
                            End_Completo = "Rua das Graças, 789, Bairro Palhaço",
                            EndDate = DateTime.Now.AddDays(-510),
                            Status = false
                        },

                    });
                    context.SaveChanges();

                }
            }
        }
    }
}
