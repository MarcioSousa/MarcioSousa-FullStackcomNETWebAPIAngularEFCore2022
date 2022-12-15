using System;
using System.Threading.Tasks;
using ProEscolas.Application.Services;
using ProEscolas.Domain;
using ProEscolas.Persistence.Interfaces;

namespace ProEscolas.Application
{
    public class AlunoService : IAlunosService
    {
        private readonly IGeralPersistence _geralPersistence;
        private readonly IAlunoPersistence _alunoPersistence;
        public AlunoService(IGeralPersistence geralPersistence, IAlunoPersistence alunoPersistence)
        {
            _geralPersistence = geralPersistence;
            _alunoPersistence = alunoPersistence;
        }

        public async Task<Aluno> Add(Aluno model)
        {
            try{
                _geralPersistence.Add<Aluno>(model);

                if(await _geralPersistence.SaveChangesAsync()){
                    return await _alunoPersistence.Get(model.Id);
                }
                return null;

            }catch(Exception ex){
                throw new Exception(ex.Message);
            }
        }
        public async Task<Aluno> Update(int alunoId, Aluno model)
        {
            try
            {
                var aluno = await _alunoPersistence.Get(alunoId);
                if(aluno == null){
                    return null;
                }

                model.Id = aluno.Id;

                _geralPersistence.Update(model);

                if(await _geralPersistence.SaveChangesAsync()){
                    return await _alunoPersistence.Get(model.Id);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> Delete(int alunoId)
        {
            try
            {
                var aluno = await _alunoPersistence.Get(alunoId);

                if(aluno == null){
                    throw new Exception("Aluno para delete não foi encontrado.");
                }

                _geralPersistence.Delete<Aluno>(aluno);

                return await _geralPersistence.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<Aluno[]> Get(string nome)
        {
            try
            {
                var alunos = await _alunoPersistence.Get(nome);
                if(alunos == null) {
                    return null;
                }
                return alunos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<Aluno[]> Get()
        {
            try
            {
                var alunos = await _alunoPersistence.Get();
                if(alunos == null) {
                    return null;
                }
                return alunos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<Aluno> Get(int alunoId)
        {
            try
            {
                var alunos = await _alunoPersistence.Get(alunoId);
                if(alunos == null) {
                    return null;
                }
                return alunos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}