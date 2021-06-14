using System;
using System.Collections.Generic;
using transferencia_bancaria_dio_localizaLabs.Enum;
using transferencia_bancaria_localizaLabs;

namespace transferencia_bancaria_dio_localizaLabs.Classes
{
    public class StatusConta
    {
        public string Mensagem { get; set; }

        public bool ObterStatus(int operacao, List<Conta> listContas)
		{
            // Validação das contas cadastradas

            if (listContas.Count == 0){
				Console.WriteLine("********************* Nenhuma conta cadastrada. *********************");
				return false;
			}
			else if(listContas.Count == 1 && operacao == 3){
				Console.WriteLine("********************* Não existe conta de destino cadastrada. *********************");
				return false;
			}else {
                return true;
            }
		}
    }

}