using ApiComDBCartões.classes;
using ApiComDBCartões.Interfaces;
using ApiComDBCartões.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiComDBCartões.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Conta : Controller
    {
        private readonly IVerificação_CadastroDeUsuario verificação_CadastroDe;
        private readonly ICredito credito1;
        private readonly IDebito debito;
        private readonly Conta_debito contaDebito= new Conta_debito();


        public Conta(IVerificação_CadastroDeUsuario verificação_CadastroDeUsuario, ICredito credito, IDebito debito)
        {
            verificação_CadastroDe = verificação_CadastroDeUsuario;
            credito1 = credito;
            this.debito = debito;

        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> CadastroUsuario(Usuario usuario,Conta_debito _Debito)
        {

            verificação_CadastroDe.CadastroDeUsuario(usuario);
           
            debito.SaldoUsuarioNovoAsync(_Debito);
          //Tem de cadastrar o saldo e o limite
            
            if(await verificação_CadastroDe.SalvarModificações())
                return Ok();

            else
               return BadRequest("Erro ao criar cadastro.");

          
        }

        /* [HttpPost("Novos titulos sem DTO.")]
         public async Task<ActionResult<CartaoCredito>> 
         {
             _jogoRepositorio.AdicionarDados(jogo);

             if (await _jogoRepositorio.SalvarModificações())
                 return Ok();

             else
                 return BadRequest("Erro ao adicionar o Titulo.");
         }*/
    }
}
/*Serão realizadas ambas operações através desse controlador.*/