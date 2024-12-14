using Teste_Estágio.Models;

namespace Teste_Estágio.Repositorio
{
    public interface ISupplierRepositorio
    {
        SuppliersModel add(SuppliersModel supplier);

        List<SuppliersModel> searchEveryItem();

        SuppliersModel searchForId(int id);

        SuppliersModel Update(SuppliersModel supplier);

        bool Delete(int id);

        List<MaterialsModel> updateMaterials(MaterialsModel material, int id);
    }
}
