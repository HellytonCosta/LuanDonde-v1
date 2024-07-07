using LuanDonde.Data;
using LuanDonde.Models;
using LuanDonde.Models.ViewModels;
using LuanDonde.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
//using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;


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
            return RedirectToAction("Index4", _formulario);

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

            _formulario.auxIndex3();
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
            _formulario.auxIndex3();
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
            //List<double> CultList = new List<double>();
            //CultList.Add(_formVM.Cultura1);
            //CultList.Add(_formVM.Cultura2);
            //CultList.Add(_formVM.Cultura3);
            //CultList.Add(_formVM.Cultura4);
            //CultList.Add(_formVM.Cultura5);
            //CultList.Add(_formVM.Cultura6);
            //// Organizando de maneira crescente
            //CultList.Sort();

            //  _formVM.CulturaMedia = _formVM.CalculoMediana(CultList);
            _formVM.CulturaMedia = (_formVM.Cultura1 / 20) + (_formVM.Cultura2 / 20) + (_formVM.Cultura3 / 20) + (_formVM.Cultura4 / 20 ) + (_formVM.Cultura5 / 20) + (_formVM.Cultura6 / 20);
            _formVM.CulturaMedia = _formVM.CulturaMedia / 30;
            _formVM.CulturaFinal = (_formVM.CulturaMedia * 100);


            //  Experiência do Cliente
            // _formVM.ExperienciaMedia = (_formVM.Experiencia1 + _formVM.Experiencia2 + _formVM.Experiencia3 + _formVM.Experiencia4 + _formVM.Experiencia5 + _formVM.Experiencia6) / 6;          

            //List<double> ExperienceList = new List<double>();
            //ExperienceList.Add(_formVM.Experiencia1);
            //ExperienceList.Add(_formVM.Experiencia2);
            //ExperienceList.Add(_formVM.Experiencia3);
            //ExperienceList.Add(_formVM.Experiencia4);
            //ExperienceList.Add(_formVM.Experiencia5);
            //ExperienceList.Add(_formVM.Experiencia6);
            //ExperienceList.Sort();
            //_formVM.ExperienciaMedia = _formVM.CalculoMediana(ExperienceList);

            _formVM.ExperienciaMedia = (_formVM.Experiencia1 / 20) + (_formVM.Experiencia2 / 20) + (_formVM.Experiencia3 / 20) + (_formVM.Experiencia4 / 20) + (_formVM.Experiencia5 / 20) + (_formVM.Experiencia6 / 20);
            _formVM.ExperienciaMedia = _formVM.ExperienciaMedia / 30;
            _formVM.ExperienciaFinal = (_formVM.ExperienciaMedia * 100);


            //  Mercado e Concorrência
            // _formVM.MercadoMedia = (_formVM.Mercado1 + _formVM.Mercado2 + _formVM.Mercado3 + _formVM.Mercado4) / 4;
            //List<double> MercadoList = new List<double>();
            //MercadoList.Add(_formVM.Mercado1);
            //MercadoList.Add(_formVM.Mercado2);
            //MercadoList.Add(_formVM.Mercado3);
            //MercadoList.Add(_formVM.Mercado4);
            //MercadoList.Sort();
            //_formVM.MercadoMedia = _formVM.CalculoMediana(MercadoList);
            _formVM.MercadoMedia = (_formVM.Mercado1 / 20) + (_formVM.Mercado2 / 20) + (_formVM.Mercado3 / 20) + (_formVM.Mercado1 / 20) ;
            _formVM.MercadoMedia = _formVM.MercadoMedia / 20 ;
            _formVM.MercadoFinal = (_formVM.MercadoMedia * 100);


            //  Inovação
            // _formVM.InovacaoMedia = (_formVM.Inovacao1 + _formVM.Inovacao2 + _formVM.Inovacao3 + _formVM.Inovacao4) / 4;
            //List<double> InovacaoList = new List<double>();
            //InovacaoList.Add(_formVM.Inovacao1);
            //InovacaoList.Add(_formVM.Inovacao2);
            //InovacaoList.Add(_formVM.Inovacao3);
            //InovacaoList.Add(_formVM.Inovacao4);
            //InovacaoList.Sort();
            //_formVM.InovacaoMedia = _formVM.CalculoMediana(InovacaoList);
            _formVM.InovacaoMedia = ((_formVM.Inovacao1 / 20) + (_formVM.Inovacao2 / 20) + (_formVM.Inovacao3 / 20) + (_formVM.Inovacao4 / 20));
            _formVM.InovacaoMedia = (_formVM.InovacaoMedia / 20);
            _formVM.InovacaoFinal = (_formVM.InovacaoMedia * 100);


            //  Processos
            // _formVM.ProcessosMedia = (_formVM.Processos1 + _formVM.Processos2 + _formVM.Processos3 + _formVM.Processos4 + _formVM.Processos5 ) / 5;
            //List<double> ProcessosList = new List<double>();
            //ProcessosList.Add(_formVM.Processos1);
            //ProcessosList.Add(_formVM.Processos2);
            //ProcessosList.Add(_formVM.Processos3);
            //ProcessosList.Add(_formVM.Processos4);
            //ProcessosList.Add(_formVM.Processos5);
            //ProcessosList.Sort();
            //_formVM.ProcessosMedia = _formVM.CalculoMediana(ProcessosList);
            _formVM.ProcessosMedia = ((_formVM.Processos1 / 20) + (_formVM.Processos2 / 20) + (_formVM.Processos3 / 20) + (_formVM.Processos4 / 20) + (_formVM.Processos5 / 20) );
            _formVM.ProcessosMedia = _formVM.ProcessosMedia / 25;
            _formVM.ProcessosFinal = (_formVM.ProcessosMedia * 100);


            //  Modelos de Negócio
            // _formVM.ModelosMedia = (_formVM.Modelos1 + _formVM.Modelos2 + _formVM.Modelos3 + _formVM.Modelos4) / 4;
            //List<double> ModelosList = new List<double>();
            //ModelosList.Add(_formVM.Modelos1);
            //ModelosList.Add(_formVM.Modelos2);
            //ModelosList.Add(_formVM.Modelos3);
            //ModelosList.Add(_formVM.Modelos4);
            //ModelosList.Sort();
            //_formVM.ModelosMedia = _formVM.CalculoMediana(ModelosList);
            _formVM.ModelosMedia = ((_formVM.Modelos1 / 20) + (_formVM.Modelos2 / 20) + (_formVM.Modelos3 / 20) + (_formVM.Modelos4 / 20));
            _formVM.ModelosMedia = (_formVM.ModelosMedia / 20);
            _formVM.ModelosFinal = (_formVM.ModelosMedia * 100);


            //  Dados
            // _formVM.DadosMedia = (_formVM.Dados1 + _formVM.Dados2 + _formVM.Dados3 + _formVM.Dados4 + _formVM.Dados5) / 5;
            //List<double> DadosList = new List<double>();
            //DadosList.Add(_formVM.Dados1);
            //DadosList.Add(_formVM.Dados2);
            //DadosList.Add(_formVM.Dados3);
            //DadosList.Add(_formVM.Dados4);
            //DadosList.Add(_formVM.Dados5);
            //DadosList.Sort();
            //_formVM.DadosMedia = _formVM.CalculoMediana(DadosList);
            _formVM.DadosMedia = ((_formVM.Dados1 / 20) + (_formVM.Dados2 / 20) + (_formVM.Dados3 / 20) + (_formVM.Dados4 / 20) + (_formVM.Dados5 / 20) );
            _formVM.DadosMedia = _formVM.DadosMedia / 25;
            _formVM.DadosFinal = (_formVM.DadosMedia * 100);


            //  Tecnologia  
            // _formVM.TecnologiaMedia = (_formVM.Tecnologia1 + _formVM.Tecnologia2 + _formVM.Tecnologia3 + _formVM.Tecnologia4 + _formVM.Tecnologia5) / 5;
            ////List<double> TecList = new List<double>();
            ////TecList.Add(_formVM.Tecnologia1);
            ////TecList.Add(_formVM.Tecnologia2);
            ////TecList.Add(_formVM.Tecnologia3);
            ////TecList.Add(_formVM.Tecnologia4);
            ////TecList.Add(_formVM.Tecnologia5);
            ////TecList.Sort();
            ////_formVM.TecnologiaMedia = _formVM.CalculoMediana(TecList);
            _formVM.TecnologiaMedia = (_formVM.Tecnologia1 / 20) + (_formVM.Tecnologia2 / 20) + (_formVM.Tecnologia3 / 20) + (_formVM.Tecnologia4 / 20) + (_formVM.Tecnologia5 / 20);
            _formVM.TecnologiaMedia = _formVM.TecnologiaMedia / 25;
            _formVM.TecnologiaFinal = (_formVM.TecnologiaMedia * 100);


            // MATURIDADE DIGITAL FINAL
            //List<double> MaturidadeList = new List<double>();
            //MaturidadeList.Add(_formVM.CulturaFinal);
            //MaturidadeList.Add(_formVM.ExperienciaFinal);
            //MaturidadeList.Add(_formVM.MercadoFinal);
            //MaturidadeList.Add(_formVM.InovacaoFinal);
            //MaturidadeList.Add(_formVM.ProcessosFinal);
            //MaturidadeList.Add(_formVM.ModelosFinal);
            //MaturidadeList.Add(_formVM.DadosFinal);
            //MaturidadeList.Add(_formVM.TecnologiaFinal);
            //MaturidadeList.Sort();
            //_formVM.MaturidadeDigital = _formVM.CalculoMediana(MaturidadeList);
            _formVM.MaturidadeDigital = (_formVM.CulturaFinal +
                                        _formVM.ExperienciaFinal +
                                        _formVM.MercadoFinal +
                                        _formVM.InovacaoFinal +
                                        _formVM.ProcessosFinal +
                                        _formVM.ModelosFinal +
                                        _formVM.DadosFinal +
                                        _formVM.TecnologiaFinal) / 8;


            
            if (_formVM.MaturidadeDigital > 100.0)
            {
                _formVM.MaturidadeDigital = 100.0;
            }


           
            if(_formVM.CulturaFinal > 100.0)
            {
                _formVM.CulturaFinal = 100.0;
            }
           
            if (_formVM.ExperienciaFinal > 100.0)
            {
                _formVM.ExperienciaFinal = 100.0;
            }
            
            if (_formVM.MercadoFinal > 100.0)
            {
                _formVM.MercadoFinal = 100.0;
            }
            
            if (_formVM.InovacaoFinal > 100.0)
            {
                _formVM.InovacaoFinal = 100.0;
            }
            
            if (_formVM.ProcessosFinal > 100.0)
            {
                _formVM.ProcessosFinal = 100.0;
            }
           
            if (_formVM.ModelosFinal > 100.0)
            {
                _formVM.ModelosFinal = 100.0;
            }
            
            if (_formVM.DadosFinal > 100.0)
            {
                _formVM.DadosFinal = 100.0;
            }
           
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

        public IActionResult AdminResultsPDF(int? id)
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
            // var model = form;// Seu modelo de dados, se necessário

            return View();

        }

        public ActionResult ExportarPDF()
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Header()
                        .Text("Hello PDF!")
                        .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(20);

                            x.Item().Text(Placeholders.LoremIpsum());
                            x.Item().Image(Placeholders.Image(200, 100));
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Page ");
                            x.CurrentPageNumber();
                        });
                });
            })
            .GeneratePdf("hello.pdf");
            return View();
        }

        public ActionResult GerarPdf(AssessmentForm obj)
        {
            string textMaturidade = "DEFAULT";
            if (obj.MaturidadeDigital <= 20.0)
                textMaturidade = "Neste estágio, a empresa mostra um entendimento muito básico ou inexistente das práticas digitais. Há pouca ou nenhuma colaboração entre equipes de diferentes departamentos para a integração digital, e o uso de ferramentas ágeis é quase inexistente. A liderança carece de compreensão clara sobre as tendências digitais e suas implicações no setor. O treinamento em habilidades digitais é escasso ou ineficaz, com pouca ênfase em fomentar a inovação ou acolher ideias novas. A experiência do cliente digital é negligenciada, e há pouco esforço em entender e utilizar dados de clientes para potencializar vendas. A empresa mostra uma reatividade limitada às mudanças do mercado e às novas tecnologias.";
            else if (obj.MaturidadeDigital > 20.0 && obj.MaturidadeDigital <= 50.0)
                textMaturidade = "Empresas emergentes estão começando a adotar práticas digitais, mas de maneira inconsistente. Existe alguma colaboração interdepartamental, e ferramentas de gerenciamento ágil começam a ser exploradas. A liderança tem um entendimento básico das tendências digitais. Há esforços pontuais para treinar colaboradores em habilidades digitais e alguma abertura para novas ideias e opiniões. A experiência do cliente digital é reconhecida, mas não totalmente integrada ou otimizada. A empresa começa a observar a concorrência e a reagir às mudanças do mercado, mas ainda de forma limitada.";
            else if (obj.MaturidadeDigital > 50.0 && obj.MaturidadeDigital <= 75.0)
                textMaturidade = "Empresas com maturidade consolidada têm uma abordagem mais integrada à digitalização. Há uma colaboração efetiva entre departamentos, e ferramentas de gerenciamento ágil são mais comuns. A liderança entende o impacto das tendências digitais no setor e promove um ambiente de aprendizado contínuo. A experiência do cliente digital é bem compreendida, e há esforços para alinhar estratégias de marketing e vendas com as preferências digitais dos clientes. A empresa reage de forma mais eficaz às mudanças do mercado e começa a inovar com alguma regularidade.";
            else if (obj.MaturidadeDigital > 75.0 && obj.MaturidadeDigital <= 90.0)
                textMaturidade = "Neste nível, a empresa exibe uma forte integração de práticas digitais em suas operações. A colaboração entre departamentos é uma norma, com uma adoção extensiva de ferramentas ágeis. A liderança possui uma compreensão profunda das tendências digitais e promove uma cultura de inovação constante. A experiência do cliente digital é central para a estratégia da empresa, com uma abordagem sofisticada de marketing e vendas digitais. A empresa é proativa em relação às mudanças do mercado e busca ativamente inovações e parcerias para manter sua vantagem competitiva.";
            else if (obj.MaturidadeDigital > 90.0 && obj.MaturidadeDigital <= 100.0)
                textMaturidade = "Empresas líderes são exemplares em maturidade digital. Demonstram excelência na colaboração interdepartamental com uma utilização avançada de ferramentas de gerenciamento ágil. A liderança tem visão de futuro e está totalmente alinhada com as tendências digitais, conduzindo a empresa com inovações disruptivas. A experiência do cliente digital é excepcional, com uma utilização avançada de dados para personalizar e otimizar a jornada do cliente. A empresa é altamente adaptável, rápida em responder às mudanças do mercado e sempre à frente em inovação e aplicação de novas tecnologias.";



            // Cria um novo documento PDF
            PdfDocument documento = new PdfDocument();

            // Adiciona uma página ao documento
            PdfPage pagina = documento.AddPage();

            // Obtém o objeto XGraphics para desenhar na página
            XGraphics gfx = XGraphics.FromPdfPage(pagina);

            // Define uma fonte para o texto
            XFont fonte = new XFont("Arial", 12);

            // Desenha um texto na página
            gfx.DrawString(textMaturidade, fonte, XBrushes.Black,
                new XRect(2, 2, pagina.Width, pagina.Height),
                XStringFormats.TopLeft);

            // Salva o documento em memória
            byte[] conteudoPdf;
            using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
            {
                documento.Save(stream, false);
                conteudoPdf = stream.ToArray();
            }

            // Retorna o PDF como um arquivo para download
            return File(conteudoPdf, "application/pdf", "MaturidadeDigital.pdf");
        }



        public ActionResult GerarCsv(AssessmentForm _form)
        {
            // Dados para o arquivo CSV (exemplo)
            var dados = new[]
            {
                new { Nome = "João", Sobrenome = "Silva", Idade = 30 },
                new { Nome = "Maria", Sobrenome = "Souza", Idade = 25 },
                new { Nome = "Pedro", Sobrenome = "Santos", Idade = 35 }
            };

            // Construir o conteúdo do arquivo CSV
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("Nome,Sobrenome,Idade");

            foreach (var pessoa in dados)
            {
                csvContent.AppendLine($"{pessoa.Nome},{pessoa.Sobrenome},{pessoa.Idade}");
            }

            // Converter o conteúdo do CSV em bytes
            byte[] csvBytes = Encoding.UTF8.GetBytes(csvContent.ToString());

            // Retornar o arquivo para download
            return File(csvBytes, "text/csv", "dados.pdf");
        }
    }

    
}
