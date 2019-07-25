using GhostBusters_Forms.Mapper;
using GhostBusters_Forms.Model;
using GhostBusters_Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Controller
{
    public class ChamadoController
    {
        public ChamadoModel Cadastro(ChamadoModel chamado)
        {
            return new ChamadoRepository().CadastroUpdate(chamado.MapChamadaEntiy()).MapChamadaModel();
        } 

        public List<ChamadoModel> Findall()
        {
            return new ChamadoRepository().FindALL().Select(Chamado => Chamado.MapChamadaModel()).ToList();
        }

        public List<ChamadoModel> FindByStatus(int id)
        {
            return new ChamadoRepository().FindByStatus(id).Select(Chamado => Chamado.MapChamadaModel()).ToList();
        }

        public List<ChamadoModel> FindByOwner(int codigo_owner)
        {
            return new ChamadoRepository().FindByOwner(codigo_owner).Select(owner => owner.MapChamadaModel()).ToList();
        }

        public List<ChamadoModel> FindByUsuario(int codigo_owner)
        {
            return new ChamadoRepository().FindByUsuario(codigo_owner).Select(owner => owner.MapChamadaModel()).ToList();
        }

        public ChamadoModel FindByID(int codigo_chamado)
        {
            return new ChamadoRepository().FindById(codigo_chamado).MapChamadaModel();
        }

        public List<ChamadoModel> FindByTecnico(int codigo_tecnico)
        {
            return new ChamadoRepository().FindByTecnico(codigo_tecnico).Select(tecnico => tecnico.MapChamadaModel()).ToList();
        }

        public void ExcluirChamado(ChamadoModel chamado)
        {
            for (int i = 0; i < chamado.anexos.Count; i++)
            {
                new AnexoController().ExcluirAnexo(chamado.anexos.ToArray()[i].Codigo_Anexo);
            }
            new ChamadoRepository().Excluir(chamado.Codigo_chamado);
        }

        public void EnviarEmail(ChamadoModel Chamado)
        {          
                MailMessage mail = new MailMessage();

                SmtpClient SmtpServer = new SmtpClient("smtp.mailtrap.io");

                mail.From = new MailAddress("cliente1@gmail.com");
                mail.To.Add(Chamado.Tech.Email);
                mail.Subject =  Chamado.Titulo;
                mail.Body = Chamado.Descricao;



                SmtpServer.Port = 2525;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ac0a02e54dc47a", "b8ed85b31e2102");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail); 
        }
    }
}
