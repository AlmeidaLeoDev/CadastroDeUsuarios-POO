using CadastroUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario
{
    internal class BaseDeDados
    {
        //List
        List<CadastroPessoa> listaDePessoas;

        //Métodos
        public void AdicionarPessoas(CadastroPessoa pPessoa)
        {
            listaDePessoas.Add(pPessoa);
        }
        public List<CadastroPessoa> PesquisaPessoasPorDoc(string pNumeroDeDocumento)
        {
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x => x.NumeroDoDocumento == pNumeroDeDocumento).ToList();
            if (listaDePessoasTemp.Count > 0)
                return listaDePessoasTemp;
            else
                return null;
        }
        public List<CadastroPessoa> RemoverPessoasPorDoc(string pNumeroDeDocumento)
        {
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x => x.NumeroDoDocumento == pNumeroDeDocumento).ToList();
            if (listaDePessoasTemp.Count > 0)
            {
                foreach (CadastroPessoa pessoa in listaDePessoasTemp)
                {
                    listaDePessoas.Remove(pessoa);
                }
                return listaDePessoasTemp;
            }
            else
                return null;
        }

        //Construtor
        public BaseDeDados()
        {
            listaDePessoas = new List<CadastroPessoa>();
        }
    }
}
