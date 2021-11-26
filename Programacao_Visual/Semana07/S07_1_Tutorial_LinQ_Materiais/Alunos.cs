using System;
using System.Collections.Generic;
using System.Text;

namespace TP06_TutorialLinQ
{
    public class Alunos : List<Aluno>
    {
        public Alunos() : base()
        {
            List<Aluno> temp = CriarAlunos();
            this.AddRange(temp);

        }

        public override string ToString()
        {
            String str = "";
            foreach (Aluno a in this)
                str += a.ToString() + "\n";
            return str;
        }

        private List<Aluno> CriarAlunos()
        {
            Aluno[] listaDeAlunos =
            {
                new Aluno
                {
                    Codigo = "160262001",
                    Nome = "Ana Bolena",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "ana.bolena@estsetubal.ips.pt",
                        Telefone = "931234567",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },
                new Aluno
                {
                    Codigo = "160262002",
                    Nome = "Bernardo Santana",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "bernardo.santana@estsetubal.ips.pt",
                        Telefone = "931234568",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
                new Aluno
                {
                    Codigo = "170262009",
                    Nome = "Filipe Almeida",
                    Inscrito = true,
                    Curso = Curso.LEEC,
                    Contacto = new Contacto(){
                        Mail = "Filipe.Almeida@estsetubal.ips.pt",
                        Telefone = "931234569",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1411",
                            Curso = Curso.LEEC,
                            Nome = "Introdução à Electrónica",
                            InscritoNoAno = AnoLetivo.A1718,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEEC,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1718,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEEC,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1718,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEEC,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1718,
                        }
                    }
                },// new Aluno
                new Aluno
                {
                    Codigo = "190262010",
                    Nome = "Gonçalo Fernandes",
                    Inscrito = true,
                    Curso = Curso.LEEC,
                    Contacto = new Contacto(){
                        Mail = "Gonçalo.Fernandesa@estsetubal.ips.pt",
                        Telefone = "931234570",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEEC,
                            Nome = "Introdução à electrónica",
                            InscritoNoAno = AnoLetivo.A1920,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEEC,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1920,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEEC,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1920,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEEC,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1920,
                        }
                    }
                },// new Aluno
                new Aluno
                {
                    Codigo = "190262014",
                    Nome = "João Mendes",
                    Inscrito = true,
                    Curso = Curso.TPSI,
                    Contacto = new Contacto(){
                        Mail = "João.Mendes@estsetubal.ips.pt",
                        Telefone = "931234571",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "2312",
                            Curso = Curso.TPSI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1920,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "2313",
                            Curso = Curso.TPSI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1920,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "2314",
                            Curso = Curso.TPSI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1920,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "2312",
                            Curso = Curso.TPSI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1920,
                        }
                    }
                },// new Aluno
                new Aluno
                {
                    Codigo = "190262001",
                    Nome = "Duarte Alcácer",
                    Inscrito = true,
                    Curso = Curso.TPSI,
                    Contacto = new Contacto(){
                        Mail = "Duarte.Alcácer@estsetubal.ips.pt",
                        Telefone = "931234572",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "2312",
                            Curso = Curso.TPSI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1920,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "2313",
                            Curso = Curso.TPSI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1920,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "2314",
                            Curso = Curso.TPSI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1920,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "2312",
                            Curso = Curso.TPSI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1920,
                        }
                    }
                },// new Aluno
                new Aluno
                {
                    Codigo = "190262018",
                    Nome = "Rui Martins",
                    Inscrito = true,
                    Curso = Curso.TPSI,
                    Contacto = new Contacto(){
                        Mail = "Rui.Martins@estsetubal.ips.pt",
                        Telefone = "931234573",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "2312",
                            Curso = Curso.TPSI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1920,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "2313",
                            Curso = Curso.TPSI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1920,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "2314",
                            Curso = Curso.TPSI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1920,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "2312",
                            Curso = Curso.TPSI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
                new Aluno
                {
                    Codigo = "190262001",
                    Nome = "André Barros",
                    Inscrito = true,
                    Curso = Curso.TPSI,
                    Contacto = new Contacto(){
                        Mail = "André.Barros@estsetubal.ips.pt",
                        Telefone = "931234574",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
                new Aluno
                {
                    Codigo = "190262003",
                    Nome = "André Silva",
                    Inscrito = true,
                    Curso = Curso.TPSI,
                    Contacto = new Contacto(){
                        Mail = "André.Silva@estsetubal.ips.pt",
                        Telefone = "931234575",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.TPSI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.TPSI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.TPSI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.TPSI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
                new Aluno
                {
                    Codigo = "190262017",
                    Nome = "Rúben Guerreiro",
                    Inscrito = true,
                    Curso = Curso.LEM,
                    Contacto = new Contacto(){
                        Mail = "Rúben.Guerreiro@estsetubal.ips.pt",
                        Telefone = "931234576",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEM,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEM,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEM,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEM,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
                new Aluno
                {
                    Codigo = "190262006",
                    Nome = "Diogo Vilela",
                    Inscrito = true,
                    Curso = Curso.LEM,
                    Contacto = new Contacto(){
                        Mail = "Diogo.Vilela@estsetubal.ips.pt",
                        Telefone = "931234577",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEM,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEM,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEM,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEM,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
                new Aluno
                {
                    Codigo = "190262078",
                    Nome = "Hélio Fontes",
                    Inscrito = true,
                    Curso = Curso.LEM,
                    Contacto = new Contacto(){
                        Mail = "Helio.Fontes@estsetubal.ips.pt",
                        Telefone = "931234568",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEM,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEM,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEM,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEM,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
                new Aluno
                {
                    Codigo = "190262015",
                    Nome = "João Ramos",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "João.Ramos@estsetubal.ips.pt",
                        Telefone = "931234579",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
                new Aluno
                {
                    Codigo = "180269023",
                    Nome = "Daniel Oliveira",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "Daniel.Oliveira@estsetubal.ips.pt",
                        Telefone = "931234580",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
                new Aluno
                {
                    Codigo = "190262020",
                    Nome = "Vítor Almeida",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "Vitor.Almeida@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
               new Aluno
                {
                    Codigo = "130221037",
                    Nome = "Andre Camuenhi",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "Andre Camuenhi@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
   
               new Aluno
                {
                    Codigo = "120221063",
                    Nome = "Andre Antunes",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "Andre.Antunes@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
               new Aluno
                {
                    Codigo = "130221094",
                    Nome = "André Castanho",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "Andre.Castanho@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
               new Aluno
                {
                    Codigo = "100221022",
                    Nome = "André Silva",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "André.Silva@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
   
               new Aluno
                {
                    Codigo = "120221013",
                    Nome = "André Nobais",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "Andre.Nobais@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
    
               new Aluno
                {
                    Codigo = "150221071",
                    Nome = "Vítor Almeida",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "Vitor.Almeida@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
   
               new Aluno
                {
                    Codigo = "120221012",
                    Nome = "André Soares",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "André.Soares@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
               new Aluno
                {
                    Codigo = "150221069",
                    Nome = "Angelo Ferreira",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "Angelo.Ferreira@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
               new Aluno
                {
                    Codigo = "142382476",
                    Nome = "António Cardoso",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "António Cardoso@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
               new Aluno
                {
                    Codigo = "120221050",
                    Nome = "Bruno Leonardo",
                    Inscrito = true,
                    Curso = Curso.LEM,
                    Contacto = new Contacto(){
                        Mail = "Bruno Leonardo@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEM,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEM,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEM,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEM,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
               new Aluno
                {
                    Codigo = "100221023",
                    Nome = "Cátia Silva",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "CatiaSilva@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
               new Aluno
                {
                    Codigo = "130221092",
                    Nome = "Cláudia David",
                    Inscrito = true,
                    Curso = Curso.LEI,
                    Contacto = new Contacto(){
                        Mail = "Claudia.David@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
               new Aluno
                {
                    Codigo = "180221050",
                    Nome = "Cláudia Silva",
                    Inscrito = true,
                    Curso = Curso.LEM,
                    Contacto = new Contacto(){
                        Mail = "Cláudia.Silva@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEM,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEM,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEM,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEM,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
               new Aluno
                {
                    Codigo = "120221035",
                    Nome = "Cynthia Mendes",
                    Inscrito = true,
                    Curso = Curso.TPSI,
                    Contacto = new Contacto(){
                        Mail = "Cynthia.Mendes@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
               new Aluno
                {
                    Codigo = "130221064",
                    Nome = "Daniela Gomes",
                    Inscrito = true,
                    Curso = Curso.TPSI,
                    Contacto = new Contacto(){
                        Mail =  "Daniela.Gomes@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
               new Aluno
                {
                    Codigo = "130221082",
                    Nome = "David Ovtchinnikov",
                    Inscrito = true,
                    Curso = Curso.TPSI,
                    Contacto = new Contacto(){
                        Mail = "David.Ovtchinnikov@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.LEI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.LEI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.LEI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno
               new Aluno
                {
                    Codigo = "130221002",
                    Nome = "Débora Campanacho",
                    Inscrito = true,
                    Curso = Curso.TPSI,
                    Contacto = new Contacto(){
                        Mail = "Débora.Campanacho@estsetubal.ips.pt",
                        Telefone = "931234581",
                    },
                    Cadeiras = new List<UnidadeCurricular>(){
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.TPSI,
                            Nome = "Introdução à programação",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1313",
                            Curso = Curso.TPSI,
                            Nome = "Matemática 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1314",
                            Curso = Curso.TPSI,
                            Nome = "Mecânica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        },
                        new UnidadeCurricular()
                        {
                            Codigo = "1312",
                            Curso = Curso.TPSI,
                            Nome = "Quimica 1",
                            InscritoNoAno = AnoLetivo.A1617,
                        }
                    }
                },// new Aluno


            };


            return new List<Aluno>(listaDeAlunos); ;
        } // termina CriarAluno()

    }
}
