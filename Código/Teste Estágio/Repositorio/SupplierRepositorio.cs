using Teste_Estágio.Context;
using Teste_Estágio.Models;

namespace Teste_Estágio.Repositorio
{
    public class SupplierRepositorio : ISupplierRepositorio
    {
        private readonly BancoContext _bancoContext;
        public SupplierRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }        

        public SuppliersModel searchForId(int id)
        {

            return _bancoContext.Supplier.FirstOrDefault(x => x.Id == id);
        }
        public SuppliersModel add(SuppliersModel supplier)
        {            
            _bancoContext.Supplier.Add(supplier);
            _bancoContext.SaveChanges();
            return supplier;
        }

        public List<SuppliersModel> searchEveryItem()
        {
            return _bancoContext.Supplier.ToList();
        }

        public SuppliersModel Update(SuppliersModel supplier)
        {
            SuppliersModel supplierAux = searchForId(supplier.Id);
            if(supplierAux == null) throw new System.Exception("Supplier not found");

            supplierAux.Name = supplier.Name;
            supplierAux.Description = supplier.Description;
            supplierAux.Address = supplier.Address;
            supplierAux.CEP = supplier.CEP;
            supplierAux.CNPJ = supplier.CNPJ;
            supplier.QrCode = '%' + supplier.CNPJ + "%-" + supplier.CEP + "%-" + "CAD." + supplier.RegistrationDay + '%';
            

            _bancoContext.Supplier.Update(supplierAux);
            _bancoContext.SaveChanges();
            return supplierAux;
        }

        public bool Delete(int id)
        {
            SuppliersModel supplier = searchForId(id);
            if (supplier == null) throw new System.Exception("Supplier not found");
            _bancoContext.Supplier.Remove(supplier);
            _bancoContext.SaveChanges();
            return true;
        }

        public List<MaterialsModel> updateMaterials(MaterialsModel material, int id)
        {
            throw new NotImplementedException();
        }
    }
}
