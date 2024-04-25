namespace LuanDonde.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IAssessmentFormRepository Formulario { get; }
        void Save();
    }
}
