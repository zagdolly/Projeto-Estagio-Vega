using Teste_Estágio.Models;

namespace Teste_Estágio.Repositorio
{
    public interface IMaterialRepositorio
    {
        MaterialsModel add(MaterialsModel material);

        List<MaterialsModel> searchEveryItem();

        MaterialsModel searchForId(int id);

        MaterialsModel Update(MaterialsModel material);

        bool Delete(int id);
    }
}
