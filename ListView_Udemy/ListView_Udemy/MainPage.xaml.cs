using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView_Udemy
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            listaFuncionario.ItemsSource = GetFuncionarios();
        }

        private List<Grupo> GetFuncionarios()
        {
            return new List<Grupo>
            {
                new Grupo("Presidente", "CEO","Presidente da Empresa")
                {
                    new Pessoa { Nome= "Wladimir", IsRequired= true, RankEficiencia = 8},
                },

                new Grupo("Diretores", "Dir.","Diretor da Empresa")
                {
                    new Pessoa { Nome= "Maria", IsRequired= false, RankEficiencia = 6},
                    new Pessoa { Nome= "Fabiana", IsRequired= true, RankEficiencia = 8},
                },

                new Grupo("Gerentes", "Ger.","Gerente da Empresa")
                {
                     new Pessoa { Nome= "Jesus", IsRequired= true, RankEficiencia = 8},
                     new Pessoa { Nome= "Deus", IsRequired= true, RankEficiencia = 8}
                },

                new Grupo("Funcionários", "Func.","Funcionários da Empresa")
                {
                     new Pessoa { Nome= "Jesus", IsRequired= false, RankEficiencia = 6},
                     new Pessoa { Nome= "Deus", IsRequired= false},
                     new Pessoa { Nome= "Jesus", IsRequired= false},
                     new Pessoa { Nome= "Jesus", IsRequired= false},
                     new Pessoa { Nome= "Jesus", IsRequired= false},
                     new Pessoa { Nome= "Débora", IsRequired= false},
                     new Pessoa { Nome= "Sabrina", IsRequired= false},
                     new Pessoa { Nome= "Denise", IsRequired= false},
                     new Pessoa { Nome= "Denise", IsRequired= false},
                     new Pessoa { Nome= "Denise", IsRequired= false},
                     new Pessoa { Nome= "Denise", IsRequired= false},
                     new Pessoa { Nome= "Denise", IsRequired= false},
                }

            };
        }

        public class Grupo : List<Pessoa>
        {
            public string Titulo { get; set; }
            public string TituloCurto { get; set; }
            public string Descricao { get; set; }

            public Grupo(string titulo, string tituloCurto, string descricao)
            {
                this.Titulo = titulo;
                this.TituloCurto = tituloCurto;
                this.Descricao = descricao;
            }
        }


        public class Pessoa
        {
            public string Nome { get; set; }
            public int RankEficiencia { get; set; }
            public bool IsRequired { get; set; }
        }
    }
}
