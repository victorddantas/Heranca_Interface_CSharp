using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionarios)
        {
            this.totalBonificacao += funcionarios.getBonificacao();

        }
        public double getBonificacao()
        {
            return this.totalBonificacao;   
        }

    }
}
