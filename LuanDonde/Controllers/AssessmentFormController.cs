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
            _formulario.auxIndex();
            _unitOfWork.Formulario.Add(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Index2", _formulario);
        }

        public IActionResult Index1(int? id)
        {
            AssessmentForm _formAux = _unitOfWork.Formulario.Get(u => u.Id == id);
            if (_formAux == null)
            {
                return NotFound();
            }
            return View(_formAux);
        }
        [HttpPost]
        public IActionResult Index1(AssessmentForm _formulario)
        {
            _formulario.auxIndex();
            _unitOfWork.Formulario.Update(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Index2", _formulario);

        }
        public IActionResult Index2(int? id)
        {
            AssessmentForm _formAux = _unitOfWork.Formulario.Get(u => u.Id == id);
            if (_formAux == null)
            {
                return NotFound();
            }
            return View(_formAux);
        }
        [HttpPost]
        public IActionResult Index2(AssessmentForm _formulario)
        {
            _formulario.auxIndex2();
            _unitOfWork.Formulario.Update(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Index3", _formulario);

        }
        public IActionResult Index3(int? id)
        {
            AssessmentForm _formAux = _unitOfWork.Formulario.Get(u => u.Id == id);
            if (_formAux == null)
            {
                return NotFound();
            }
            return View(_formAux);
        }
        [HttpPost]
        public IActionResult Index3(AssessmentForm _formulario)
        {
            _formulario.auxIndex3();
            _unitOfWork.Formulario.Update(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Index4", _formulario);

        }
        public IActionResult Index4(int? id)
        {
            AssessmentForm _formAux = _unitOfWork.Formulario.Get(u => u.Id == id);
            if (_formAux == null)
            {
                return NotFound();
            }
            return View(_formAux);
        }
        [HttpPost]
        public IActionResult Index4(AssessmentForm _formulario)
        {
            _formulario.auxIndex4();
            _unitOfWork.Formulario.Update(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Formulario1", _formulario);

        }

        public IActionResult Formulario1(int? id)
        {
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
        public IActionResult Formulario1(AssessmentForm _formulario)
        {
            _formulario.auxIndex4();
            _unitOfWork.Formulario.Update(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Formulario2", _formulario);
        }
        public IActionResult Formulario2(int? id)
        {
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
        public IActionResult Formulario2(AssessmentForm _formulario)
        {
            _formulario.auxIndex4();
            _unitOfWork.Formulario.Update(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Formulario3", _formulario);
        }
        public IActionResult Formulario3(int? id)
        {
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
        public IActionResult Formulario3(AssessmentForm _formulario)
        {
            _formulario.auxIndex4();
            _unitOfWork.Formulario.Update(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Formulario4", _formulario);
        }
        public IActionResult Formulario4(int? id)
        {
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
        public IActionResult Formulario4(AssessmentForm _formulario)
        {
            _formulario.auxIndex4();
            _unitOfWork.Formulario.Update(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Formulario5", _formulario);
        }
        public IActionResult Formulario5(int? id)
        {
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
        public IActionResult Formulario5(AssessmentForm _formulario)
        {
            _formulario.auxIndex4();
            _unitOfWork.Formulario.Update(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Formulario6", _formulario);
        }
        public IActionResult Formulario6(int? id)
        {
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
        public IActionResult Formulario6(AssessmentForm _formulario)
        {
            _formulario.auxIndex4();
            _unitOfWork.Formulario.Update(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Formulario7", _formulario);
        }
        public IActionResult Formulario7(int? id)
        {
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
        public IActionResult Formulario7(AssessmentForm _formulario)
        {
            _formulario.auxIndex4();
            _unitOfWork.Formulario.Update(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Formulario8", _formulario);
        }

        public IActionResult Formulario8(int? id)
        {
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

        // MÉTODO QUE REALIZA TODAS AS CONTAS DO FORMULÁRIO
        [HttpPost]
        public IActionResult Formulario8(AssessmentForm _formVM)
        {

            _formVM.auxIndex4();

            //  Cultura e pessoas
            
            //_formVM.CulturaMedia = (_formVM.Cultura1 + _formVM.Cultura2 + _formVM.Cultura3 + _formVM.Cultura4 + _formVM.Cultura5 + _formVM.Cultura6) / 6;
            

            // Inserindo em uma lista 
            List<double> CultList = new List<double>();
            CultList.Add(_formVM.Cultura1);
            CultList.Add(_formVM.Cultura2);
            CultList.Add(_formVM.Cultura3);
            CultList.Add(_formVM.Cultura4);
            CultList.Add(_formVM.Cultura5);
            CultList.Add(_formVM.Cultura6);
            // Organizando de maneira crescente
            CultList.Sort();

            _formVM.CulturaMedia = _formVM.CalculoMediana(CultList);
            _formVM.CulturaFinal = (_formVM.CulturaMedia * 10);


            //  Experiência do Cliente
            // _formVM.ExperienciaMedia = (_formVM.Experiencia1 + _formVM.Experiencia2 + _formVM.Experiencia3 + _formVM.Experiencia4 + _formVM.Experiencia5 + _formVM.Experiencia6) / 6;          

            List<double> ExperienceList = new List<double>();
            ExperienceList.Add(_formVM.Experiencia1);
            ExperienceList.Add(_formVM.Experiencia2);
            ExperienceList.Add(_formVM.Experiencia3);
            ExperienceList.Add(_formVM.Experiencia4);
            ExperienceList.Add(_formVM.Experiencia5);
            ExperienceList.Add(_formVM.Experiencia6);
            ExperienceList.Sort();
            _formVM.ExperienciaMedia = _formVM.CalculoMediana(ExperienceList);
            _formVM.ExperienciaFinal = (_formVM.ExperienciaMedia * 15);


            //  Mercado e Concorrência
            // _formVM.MercadoMedia = (_formVM.Mercado1 + _formVM.Mercado2 + _formVM.Mercado3 + _formVM.Mercado4) / 4;
            List<double> MercadoList = new List<double>();
            MercadoList.Add(_formVM.Mercado1);
            MercadoList.Add(_formVM.Mercado2);
            MercadoList.Add(_formVM.Mercado3);
            MercadoList.Add(_formVM.Mercado4);
            MercadoList.Sort();
            _formVM.MercadoMedia = _formVM.CalculoMediana(MercadoList);
            _formVM.MercadoFinal = (_formVM.MercadoMedia * 10);
                

            //  Inovação
            // _formVM.InovacaoMedia = (_formVM.Inovacao1 + _formVM.Inovacao2 + _formVM.Inovacao3 + _formVM.Inovacao4) / 4;
            List<double> InovacaoList = new List<double>();
            InovacaoList.Add(_formVM.Inovacao1);
            InovacaoList.Add(_formVM.Inovacao2);
            InovacaoList.Add(_formVM.Inovacao3);
            InovacaoList.Add(_formVM.Inovacao4);
            InovacaoList.Sort();
            _formVM.InovacaoMedia = _formVM.CalculoMediana(InovacaoList);
            _formVM.InovacaoFinal = (_formVM.InovacaoMedia * 10);


            //  Processos
            // _formVM.ProcessosMedia = (_formVM.Processos1 + _formVM.Processos2 + _formVM.Processos3 + _formVM.Processos4 + _formVM.Processos5 ) / 5;
            List<double> ProcessosList = new List<double>();
            ProcessosList.Add(_formVM.Processos1);
            ProcessosList.Add(_formVM.Processos2);
            ProcessosList.Add(_formVM.Processos3);
            ProcessosList.Add(_formVM.Processos4);
            ProcessosList.Add(_formVM.Processos5);
            ProcessosList.Sort();
            _formVM.ProcessosMedia = _formVM.CalculoMediana(ProcessosList);
            _formVM.ProcessosFinal = (_formVM.ProcessosMedia * 15);


            //  Modelos de Negócio
            // _formVM.ModelosMedia = (_formVM.Modelos1 + _formVM.Modelos2 + _formVM.Modelos3 + _formVM.Modelos4) / 4;
            List<double> ModelosList = new List<double>();
            ModelosList.Add(_formVM.Modelos1);
            ModelosList.Add(_formVM.Modelos2);
            ModelosList.Add(_formVM.Modelos3);
            ModelosList.Add(_formVM.Modelos4);
            ModelosList.Sort();
            _formVM.ModelosMedia = _formVM.CalculoMediana(ModelosList);
            _formVM.ModelosFinal = (_formVM.ModelosMedia * 15);


            //  Dados
            // _formVM.DadosMedia = (_formVM.Dados1 + _formVM.Dados2 + _formVM.Dados3 + _formVM.Dados4 + _formVM.Dados5) / 5;
            List<double> DadosList = new List<double>();
            DadosList.Add(_formVM.Dados1);
            DadosList.Add(_formVM.Dados2);
            DadosList.Add(_formVM.Dados3);
            DadosList.Add(_formVM.Dados4);
            DadosList.Add(_formVM.Dados5);
            DadosList.Sort();
            _formVM.DadosMedia = _formVM.CalculoMediana(DadosList);
            _formVM.DadosFinal = (_formVM.DadosMedia * 10);
                

            //  Tecnologia  
            // _formVM.TecnologiaMedia = (_formVM.Tecnologia1 + _formVM.Tecnologia2 + _formVM.Tecnologia3 + _formVM.Tecnologia4 + _formVM.Tecnologia5) / 5;
            List<double> TecList = new List<double>();
            TecList.Add(_formVM.Tecnologia1);
            TecList.Add(_formVM.Tecnologia2);
            TecList.Add(_formVM.Tecnologia3);
            TecList.Add(_formVM.Tecnologia4);
            TecList.Add(_formVM.Tecnologia5);
            TecList.Sort();
            _formVM.TecnologiaMedia = _formVM.CalculoMediana(TecList);
            _formVM.TecnologiaFinal = (_formVM.TecnologiaMedia* 15);   

            List<double> MaturidadeList = new List<double>();
            MaturidadeList.Add(_formVM.CulturaFinal);
            MaturidadeList.Add(_formVM.ExperienciaFinal);
            MaturidadeList.Add(_formVM.MercadoFinal);
            MaturidadeList.Add(_formVM.InovacaoFinal);
            MaturidadeList.Add(_formVM.ProcessosFinal);
            MaturidadeList.Add(_formVM.ModelosFinal);
            MaturidadeList.Add(_formVM.DadosFinal);
            MaturidadeList.Add(_formVM.TecnologiaFinal);
            MaturidadeList.Sort();
            _formVM.MaturidadeDigital = _formVM.CalculoMediana(MaturidadeList);


             _formVM.MaturidadeDigital = _formVM.MaturidadeDigital / 10;
            if (_formVM.MaturidadeDigital > 100.0)
            {
                _formVM.MaturidadeDigital = 100.0;
            }


            _formVM.CulturaFinal = _formVM.CulturaFinal / 10;
            if(_formVM.CulturaFinal > 100.0)
            {
                _formVM.CulturaFinal = 100.0;
            }
            _formVM.ExperienciaFinal = _formVM.ExperienciaFinal / 10;
            if (_formVM.ExperienciaFinal > 100.0)
            {
                _formVM.ExperienciaFinal = 100.0;
            }
            _formVM.MercadoFinal = _formVM.MercadoFinal / 10;
            if (_formVM.MercadoFinal > 100.0)
            {
                _formVM.MercadoFinal = 100.0;
            }
            _formVM.InovacaoFinal = _formVM.InovacaoFinal / 10;
            if (_formVM.InovacaoFinal > 100.0)
            {
                _formVM.InovacaoFinal = 100.0;
            }
            _formVM.ProcessosFinal = _formVM.ProcessosFinal / 10;
            if (_formVM.ProcessosFinal > 100.0)
            {
                _formVM.ProcessosFinal = 100.0;
            }
            _formVM.ModelosFinal = _formVM.ModelosFinal / 10;
            if (_formVM.ModelosFinal > 100.0)
            {
                _formVM.ModelosFinal = 100.0;
            }
            _formVM.DadosFinal = _formVM.DadosFinal / 10;
            if (_formVM.DadosFinal > 100.0)
            {
                _formVM.DadosFinal = 100.0;
            }
            _formVM.TecnologiaFinal = _formVM.TecnologiaFinal / 10;
            if (_formVM.TecnologiaFinal > 100.0)
            {
                _formVM.TecnologiaFinal = 100.0;
            }

            _unitOfWork.Formulario.Update(_formVM);
            _unitOfWork.Save();

            return RedirectToAction("Question1", _formVM);
            //  return RedirectToAction("Results", _formVM);
        }
        public IActionResult Question1(int? id)
        {
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
        public IActionResult Question1(AssessmentForm _formulario)
        {
            _formulario.auxQuestion1();
           _unitOfWork.Formulario.Update(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Question2", _formulario);
        }
        public IActionResult Question2(int? id)
        {
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
        public IActionResult Question2(AssessmentForm _formulario)
        {
            _formulario.auxQuestion2();
            _unitOfWork.Formulario.Update(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("Question3", _formulario);
        }
        public IActionResult Question3(int? id)
        {
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
        public IActionResult Question3(AssessmentForm _formulario)
        {
            _formulario.auxQuestion3();
            _unitOfWork.Formulario.Update(_formulario);
            _unitOfWork.Save();
            _id = _formulario.Id;
            return RedirectToAction("AdminResults", _formulario); 
        }

        public IActionResult Results(AssessmentForm _form)
        {
            // AssessmentForm _form = _unitOfWork.Formulario.Get(u => u.Id == id);
            return View(_form);
        }
        public IActionResult Admin()
        {
            List<AssessmentForm> formList = _unitOfWork.Formulario.GetAll().ToList();
            return View(formList);
        }


        public IActionResult AdminResults(int? id)
        {
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
        public ActionResult ReceberValorDoModal(bool value)
        {
            // Faça o que quiser com o valor recebido do modal
            ViewBag.ValorRecebido = value;
            return PartialView(); // Retorna uma PartialView se necessário
            // return RedirectToAction("Index", "Home");
        }



    }
}
