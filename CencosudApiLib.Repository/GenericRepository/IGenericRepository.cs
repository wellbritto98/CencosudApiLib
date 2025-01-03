﻿using CencosudApiLib.Models.Base;

namespace CencosudApiLib.Repository.GenericRepository;

/// <summary>
/// Interface para o repositório genérico que define operações CRUD.
/// </summary>
/// <typeparam name="T">O tipo da entidade que herda de BaseEntity.</typeparam>
public interface IGenericRepository<T> where T : BaseEntity
{
    /// <summary>
    /// Obtém todas as entidades do banco de dados.
    /// </summary>
    /// <returns>Uma lista de todas as entidades.</returns>
    Task<IEnumerable<T>> GetAllAsync();

    /// <summary>
    /// Encontra entidades que correspondem aos critérios fornecidos por uma função de filtro.
    /// </summary>
    /// <param name="queryFilter">
    /// Uma função que aplica critérios de filtro a um IQueryable.
    /// 
    /// Exemplo de uso:
    /// 
    /// <code>
    /// var resultados = await repository.FindAsync(query => query.Where(e => e.Nome == "John Doe" && e.Idade > 30));
    /// </code>
    /// </param>
    /// <returns>Uma lista de entidades que atendem aos critérios de filtro.</returns>
    Task<IEnumerable<T>> FindAsync(Func<IQueryable<T>, IQueryable<T>> queryFilter = null);

    /// <summary>
    /// Obtém uma entidade por seus valores chave.
    /// </summary>
    /// <param name="keyValues">Os valores chave da entidade.</param>
    /// <returns>A entidade correspondente ou null se não encontrada.</returns>
    Task<T> GetByIdAsync(params object[] keyValues);

    /// <summary>
    /// Adiciona uma nova entidade ao banco de dados.
    /// </summary>
    /// <param name="entity">A entidade a ser adicionada.</param>
    /// <returns>A entidade adicionada.</returns>
    Task<T> AddAsync(T entity);

    /// <summary>
    /// Atualiza uma entidade existente no banco de dados.
    /// </summary>
    /// <param name="entity">A entidade a ser atualizada.</param>
    /// <returns>A entidade atualizada.</returns>
    Task<T> UpdateAsync(T entity);

    /// <summary>
    /// Exclui uma entidade do banco de dados com base nos valores de chave fornecidos.
    /// </summary>
    /// <param name="keyValues">Os valores chave da entidade a ser excluída.</param>
    Task DeleteAsync(params object[] keyValues);
}
