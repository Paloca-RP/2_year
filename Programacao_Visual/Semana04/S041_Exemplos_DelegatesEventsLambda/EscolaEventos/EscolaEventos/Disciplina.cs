using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaEventos
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public string AnoLectivo { get; set; }
        private List<Aluno> alunos = new List<Aluno>();
        private bool inscricoesAbertas;

        /// <summary>
        /// Para quem quiser saber que as inscrições na disciplina foram abertas
        /// </summary>
        public event InformacaoDisciplina InscricoesAbriram;

        public Disciplina(string nome)
        {
            Nome = nome;
            AnoLectivo = "2012/2013";
            inscricoesAbertas = false;
        }

        public void Inscrever(Aluno aluno)
        {
            if (inscricoesAbertas)
                alunos.Add(aluno);
        }

        public void AbrirInscricoes()
        {
            inscricoesAbertas = true;
            OnInscricoesAbertas();
        }

        protected void OnInscricoesAbertas()
        {
            // Chama todos os métodos inscritos no evento InscricoesAbertas
            if (InscricoesAbriram != null)
                InscricoesAbriram(this);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nome).Append(" -- Ano lectivo: ").Append(AnoLectivo);

            if (alunos.Count > 0)
            {
                sb.Append("\nAlunos:\n");
                foreach (Aluno aluno in alunos)
                    sb.Append(aluno.ToString()).Append("\n");
            }

            return sb.ToString();
        }
    }
}
