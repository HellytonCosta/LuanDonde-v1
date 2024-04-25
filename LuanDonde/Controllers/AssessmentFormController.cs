using LuanDonde.Data;
using LuanDonde.Models;
using LuanDonde.Models.ViewModels;
using LuanDonde.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LuanDonde.Controllers
{
    public class AssessmentFormController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        // AssessmentForm _form = new AssessmentForm();
        // AssessmentFormVM _form = new AssessmentFormVM();
        //  _form.AssessmentForm = new AssessmentForm();
        public int _id;

        public AssessmentFormController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index() 
        { 
            return View(); 
        }
        [HttpPost]
        public IActionResult Index(AssessmentForm _formulario) 
        { 
            _unitOfWork.Formulario.Add(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Formulario", _formulario);
            // return View(_formulario.Id); 
        }

        
        public IActionResult Formulario(int? id)
        {
            // id = _id;
            if (id == null || id == 0)
            {
                return NotFound();
            }
            AssessmentForm _formAux = _unitOfWork.Formulario.Get(u => u.Id == id);
            if (_formAux == null)
            {
                return NotFound();
            }
            return View(_formAux);
        }

        [HttpPost]
        public IActionResult Formulario(AssessmentForm _formVM)
        {

            // AssessmentForm _formVM = new AssessmentForm();
            // _formVM = _formVM1;
            // _formVM.AssessmentForm = new AssessmentForm();
            // _formVM.ContatoId = _formVM1.ContatoId;


            // _formVM.AssessmentForm.ContatoId = (contato.Id);
            // _formVM.AssessmentForm.ContatoId = 52;
            // _formVM.ContatoId = 52;

            //  Cultura e pessoas
            _formVM.CulturaMedia = (_formVM.Cultura1 + _formVM.Cultura2 + _formVM.Cultura3 + _formVM.Cultura4 + _formVM.Cultura5 + _formVM.Cultura6) / 6;
            _formVM.CulturaFinal = (_formVM.CulturaMedia * 10) / 100;

            //  Experiência do Cliente
            _formVM.ExperienciaMedia = (_formVM.Experiencia1 + _formVM.Experiencia2 + _formVM.Experiencia3 + _formVM.Experiencia4 + _formVM.Experiencia5 + _formVM.Experiencia6) / 6;
            _formVM.ExperienciaFinal = (_formVM.ExperienciaMedia * 15) / 100; 

            //  Mercado e Concorrência
            _formVM.MercadoMedia = (_formVM.Mercado1 + _formVM.Mercado2 + _formVM.Mercado3 + _formVM.Mercado4) / 4;
            _formVM.MercadoFinal = (_formVM.MercadoMedia * 10) / 100;
                
            //  Inovação
            _formVM.InovacaoMedia = (_formVM.Inovacao1 + _formVM.Inovacao2 + _formVM.Inovacao3 + _formVM.Inovacao4) / 4;
            _formVM.InovacaoFinal = (_formVM.InovacaoMedia * 10) / 100;

            //  Processos
            _formVM.ProcessosMedia = (_formVM.Processos1 + _formVM.Processos2 + _formVM.Processos3 + _formVM.Processos4 + _formVM.Processos5 ) / 5;
            _formVM.ProcessosFinal = (_formVM.ProcessosMedia * 15) / 100;

            //  Modelos de Negócio
            _formVM.ModelosMedia = (_formVM.Modelos1 + _formVM.Modelos2 + _formVM.Modelos3 + _formVM.Modelos4) / 4;
            _formVM.ModelosFinal = (_formVM.ModelosMedia * 15) / 100;

            //  Dados
            _formVM.DadosMedia = (_formVM.Dados1 + _formVM.Dados2 + _formVM.Dados3 + _formVM.Dados4 + _formVM.Dados5) / 5;
            _formVM.DadosFinal = (_formVM.DadosMedia * 10) / 100;
                
            //  Tecnologia  
            _formVM.TecnologiaMedia = (_formVM.Tecnologia1 + _formVM.Tecnologia2 + _formVM.Tecnologia3 + _formVM.Tecnologia4 + _formVM.Tecnologia5) / 5;
            _formVM.TecnologiaFinal = (_formVM.TecnologiaMedia* 15) / 100;   

           

            _formVM.MaturidadeDigital = _formVM.CulturaFinal + _formVM.ExperienciaFinal + _formVM.MercadoFinal + _formVM.InovacaoFinal + _formVM.ProcessosFinal + _formVM.ModelosFinal + _formVM.DadosFinal + _formVM.TecnologiaFinal;



            Math.Round(_formVM.MaturidadeDigital, 1);
            Math.Round(_formVM.CulturaFinal, 1);
            Math.Round(_formVM.ExperienciaFinal, 1);
            Math.Round(_formVM.MercadoFinal, 1);
            Math.Round(_formVM.InovacaoFinal, 1);
            Math.Round(_formVM.ProcessosFinal, 1);
            Math.Round(_formVM.ModelosFinal, 1);
            Math.Round(_formVM.DadosFinal, 1);
            Math.Round(_formVM.TecnologiaFinal, 1);

            /* --------TESTES HC-------- */

            // _formVM.ContatoId = _form.ContatoId;
            // _formVM.ContatoId = _form.ContatoId;
            // _form = _formVM;

            _unitOfWork.Formulario.Update(_formVM);
            _unitOfWork.Save();

            // return RedirectToAction("Results", form.Id);
              return RedirectToAction("Results", _formVM);
        }

        public IActionResult Results(AssessmentForm _form)
        {
            // AssessmentForm _form = _unitOfWork.Formulario.Get(u => u.Id == id);
            return View(_form);
        }
    }
}
