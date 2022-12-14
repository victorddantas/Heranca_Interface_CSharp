using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 7000)
        {
        }
        public override double getBonificacao()
        {
            return Salario *= 0.5;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.7;
        }

    }
}
