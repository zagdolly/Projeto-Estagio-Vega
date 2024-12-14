using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Teste_Estágio.Context;
using Teste_Estágio.Models;

namespace Teste_Estágio.Repositorio
{
    public class MaterialRepositorio : IMaterialRepositorio
    {
        private readonly BancoContext _bancoContext;
        public MaterialRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public MaterialsModel searchForId(int id)
        {

            return _bancoContext.Material.FirstOrDefault(x => x.Id == id);
        }

        public MaterialsModel add(MaterialsModel material)
        {
            
            _bancoContext.Material.Add(material);
            _bancoContext.SaveChanges();
            return material;
        }

        public List<MaterialsModel> searchEveryItem()
        {
            return _bancoContext.Material.ToList();
        }


        public MaterialsModel Update(MaterialsModel material)
        {
            MaterialsModel materialAux = searchForId(material.Id);
            if (materialAux == null) throw new System.Exception("Material not found");

            materialAux.Name = material.Name;
            materialAux.Code = material.Code;
            materialAux.Description = material.Description;
            materialAux.FiscalCode = material.FiscalCode;
            materialAux.Specie = material.Specie;
            materialAux.UpdatedBy = material.UpdatedBy;
            materialAux.UpdatedAt = DateTime.Now;

            _bancoContext.Material.Update(materialAux);
            _bancoContext.SaveChanges();
            return materialAux;
        }

        
        public bool Delete(int id)
        {
            MaterialsModel material = searchForId(id);
            if (material == null) throw new System.Exception("Material not found");
            _bancoContext.Material.Remove(material);
            _bancoContext.SaveChanges();
            return true;
        }

        
    }
}
   