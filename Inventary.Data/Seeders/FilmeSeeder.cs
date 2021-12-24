using Inventary.Domain.Entities;

namespace Inventary.Data.Seeders;

public class FilmeSeeder
{
    private readonly ApplicationDbContext _dbContext;
    public FilmeSeeder(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Seed()
    {
        var contemFilmes = _dbContext.Filmes!.Any();

        if (!contemFilmes)
        {
            _dbContext.Filmes!.AddRange(new Filme[]
            {
                new Filme {
                Identificacao = "Beautiful Kate",
                Categoria = "Drama|Mystery",
                Duracao = 68.9,
                FaixaEtaria = 12,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Friend of the Deceased, A (Priyatel pokonika)",
                Categoria = "Comedy|Drama",
                Duracao = 22.4,
                FaixaEtaria = 12,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "I'm the One That I Want",
                Categoria = "Comedy",
                Duracao = 77.8,
                FaixaEtaria = 12,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Wise Guys, The (Les grandes gueules)",
                Categoria = "Comedy|Drama",
                Duracao = 85.4,
                FaixaEtaria = 18,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "White Hunter, Black Heart",
                Categoria = "Adventure|Drama",
                Duracao = 33.8,
                FaixaEtaria = 17,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Net, The",
                Categoria = "Action|Crime|Thriller",
                Duracao = 29.9,
                FaixaEtaria = 13,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Killers",
                Categoria = "Action|Crime|Drama|Thriller",
                Duracao = 47.4,
                FaixaEtaria = 15,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Englishman in New York, An",
                Categoria = "Drama",
                Duracao = 22.0,
                FaixaEtaria = 15,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "The Hyperboloid of Engineer Garin (Giperboloid inzhenera Garina)",
                Categoria = "Sci-Fi",
                Duracao = 81.0,
                FaixaEtaria = 14,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Ants in the Pants 2",
                Categoria = "Comedy",
                Duracao = 82.2,
                FaixaEtaria = 13,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Hugh Hefner: Playboy, Activist and Rebel",
                Categoria = "Documentary",
                Duracao = 55.0,
                FaixaEtaria = 16,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Cube 2: Hypercube",
                Categoria = "Horror|Mystery|Sci-Fi",
                Duracao = 79.8,
                FaixaEtaria = 15,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "RFK Must Die: The Assassination of Bobby Kennedy",
                Categoria = "Documentary",
                Duracao = 6.8,
                FaixaEtaria = 17,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Letter from Siberia",
                Categoria = "(no genres listed)",
                Duracao = 23.3,
                FaixaEtaria = 15,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Secret of the Wings",
                Categoria = "Adventure|Animation|Children|Fantasy",
                Duracao = 90.1,
                FaixaEtaria = 16,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Yongary: Monster from the Deep",
                Categoria = "Children|Horror|Sci-Fi",
                Duracao = 42.8,
                FaixaEtaria = 17,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Mein Kampf",
                Categoria = "Comedy|Drama",
                Duracao = 98.2,
                FaixaEtaria = 13,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Happy New Year (La Bonne Année)",
                Categoria = "Comedy|Crime|Drama",
                Duracao = 65.9,
                FaixaEtaria = 15,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Mickey's The Prince and the Pauper",
                Categoria = "Animation|Children",
                Duracao = 31.0,
                FaixaEtaria = 14,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Situation, The",
                Categoria = "Drama",
                Duracao = 22.1,
                FaixaEtaria = 18,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Loves of a Blonde (Lásky jedné plavovlásky)",
                Categoria = "Comedy|Drama|Romance",
                Duracao = 25.7,
                FaixaEtaria = 13,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Susannah of the Mounties",
                Categoria = "Drama",
                Duracao = 77.3,
                FaixaEtaria = 17,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Barnyard: The Original Party Animals",
                Categoria = "Animation|Children|Comedy",
                Duracao = 69.5,
                FaixaEtaria = 17,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Gravity",
                Categoria = "Action|Sci-Fi|IMAX",
                Duracao = 54.1,
                FaixaEtaria = 16,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Diplomatic Siege",
                Categoria = "Action|Thriller",
                Duracao = 8.2,
                FaixaEtaria = 13,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Conspiracy Theory",
                Categoria = "Drama|Mystery|Romance|Thriller",
                Duracao = 54.1,
                FaixaEtaria = 13,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Long Hello and Short Goodbye",
                Categoria = "Comedy|Thriller",
                Duracao = 1.0,
                FaixaEtaria = 14,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Sacrifice, The (Offret - Sacraficatio)",
                Categoria = "Drama",
                Duracao = 33.6,
                FaixaEtaria = 13,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Eva (a.k.a. Eve)",
                Categoria = "Drama",
                Duracao = 26.0,
                FaixaEtaria = 13,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Valley Of Flowers",
                Categoria = "Adventure|Drama|Romance",
                Duracao = 38.5,
                FaixaEtaria = 18,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Crisis",
                Categoria = "Drama|Thriller",
                Duracao = 21.9,
                FaixaEtaria = 14,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Hope Springs",
                Categoria = "Comedy|Drama",
                Duracao = 20.0,
                FaixaEtaria = 18,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "She Had to Say Yes",
                Categoria = "Drama",
                Duracao = 82.6,
                FaixaEtaria = 12,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "He Was a Quiet Man",
                Categoria = "Drama",
                Duracao = 15.7,
                FaixaEtaria = 12,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Pellet (Bola, El)",
                Categoria = "Drama",
                Duracao = 72.0,
                FaixaEtaria = 15,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "God Bless America",
                Categoria = "Comedy|Drama",
                Duracao = 15.4,
                FaixaEtaria = 14,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Miss Bala",
                Categoria = "Action|Adventure|Drama|Thriller",
                Duracao = 2.5,
                FaixaEtaria = 12,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Earth Is a Sinful Song, The (Maa on syntinen laulu)",
                Categoria = "Drama",
                Duracao = 98.4,
                FaixaEtaria = 16,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Champagne",
                Categoria = "Comedy",
                Duracao = 72.5,
                FaixaEtaria = 14,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Sanatorium",
                Categoria = "Thriller",
                Duracao = 20.9,
                FaixaEtaria = 17,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            },
            new Filme {
                Identificacao = "Young Einstein",
                Categoria = "Comedy",
                Duracao = 59.9,
                FaixaEtaria = 14,
                AtualizadoEm = DateTime.Now,
                CriadoEm = DateTime.Now
            }
            });

            _dbContext.SaveChanges();
        }
    }
}