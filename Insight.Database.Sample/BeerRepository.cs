﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insight.Database.Sample
{
	/// <summary>
	/// Defines a repository interface.
	/// </summary>
	/// <remarks>Generated by InsightRepository.snippet. Extend this with methods in a separate partial interface.</remarks>
    partial interface IBeerRepository : IDbConnection, IDbTransaction
	{
        #region Single Sync CRUD Methods
		/// <summary>
		/// Selects a single Beer from the repository by identifier.
		/// </summary>
		/// <param name="id">The id of the Beer.</param>
		/// <returns>The selected Beer.</returns>
		Beer SelectBeer(int id);

		/// <summary>
		/// Inserts a single Beer into the repository.
		/// </summary>
		/// <param name="beer">The Beer to insert.</param>
		void InsertBeer(Beer beer);

		/// <summary>
		/// Updates a single Beer in the repository.
		/// </summary>
		/// <param name="beer">The Beer to update.</param>
		void UpdateBeer(Beer beer);

		/// <summary>
		/// Upserts a single Beer in the repository.
		/// </summary>
		/// <param name="beer">The Beer to upsert.</param>
		void UpsertBeer(Beer beer);

		/// <summary>
		/// Deletes a Beer in the repository matching the given identifier.
		/// </summary>
		/// <param name="id">The id of the Beer.</param>
		void DeleteBeer(int id);
        #endregion

        #region Multiple Sync CRUD Methods
		/// <summary>
		/// Selects multiple Beers from the repository by identifier.
		/// </summary>
		/// <param name="id">The id of the Beers.</param>
		/// <returns>The selected Beer.</returns>
		IList<Beer> SelectBeers(IEnumerable<int> id);

		/// <summary>
		/// Inserts multiple Beers into the repository.
		/// </summary>
		/// <param name="beer">The Beers to insert.</param>
		void InsertBeers(IEnumerable<Beer> beer);

		/// <summary>
		/// Updates multiple Beers in the repository.
		/// </summary>
		/// <param name="beer">The Beers to update.</param>
		void UpdateBeers(IEnumerable<Beer> beer);

		/// <summary>
		/// Upserts multiple Beers in the repository.
		/// </summary>
		/// <param name="beer">The Beers to upsert.</param>
		void UpsertBeers(IEnumerable<Beer> beer);

		/// <summary>
		/// Deletes multiple Beers in the repository matching the given identifier.
		/// </summary>
		/// <param name="id">The id of the Beers.</param>
		void DeleteBeers(IEnumerable<int> id);
        #endregion

        #region Find Sync Methods
		/// <summary>
		/// Finds Beers matching a filter object.
		/// </summary>
		/// <param name="filter">The filter to use.</param>
		/// <returns>The selected Beers.</returns>
        IList<Beer> FindBeers(object filter);
        #endregion

        #region Single Async CRUD Methods
		/// <summary>
		/// Asynchronously selects a single Beer from the repository by identifier.
		/// </summary>
		/// <param name="id">The id of the Beer.</param>
		/// <returns>A task returning the selected Beer.</returns>
		Task<Beer> SelectBeerAsync(int id);

		/// <summary>
		/// Asynchronously Inserts a single Beer into the repository.
		/// </summary>
		/// <param name="beer">The Beer to insert.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task InsertBeerAsync(Beer beer);

		/// <summary>
		/// Asynchronously updates a single Beer in the repository.
		/// </summary>
		/// <param name="beer">The Beer to update.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task UpdateBeerAsync(Beer beer);

		/// <summary>
		/// Asynchronously updates a single Beer in the repository.
		/// </summary>
		/// <param name="beer">The Beer to upsert.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task UpsertBeerAsync(Beer beer);

		/// <summary>
		/// Asynchronously deletes a Beer in the repository matching the given identifier.
		/// </summary>
		/// <param name="id">The id of the Beer.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task DeleteBeerAsync(int id);
        #endregion

        #region Multiple Async CRUD Methods
		/// <summary>
		/// Asynchronously selects multiple Beers from the repository by identifier.
		/// </summary>
		/// <param name="id">The id of the Beers.</param>
		/// <returns>A task returning the selected Beers.</returns>
		Task<IList<Beer>> SelectBeersAsync(IEnumerable<int> id);

		/// <summary>
		/// Asynchronously Inserts multiple Beers into the repository.
		/// </summary>
		/// <param name="beer">The Beers to insert.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task InsertBeersAsync(IEnumerable<Beer> beer);

		/// <summary>
		/// Asynchronously updates multiple Beers in the repository.
		/// </summary>
		/// <param name="beer">The Beers to update.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task UpdateBeersAsync(IEnumerable<Beer> beer);

		/// <summary>
		/// Asynchronously updates multiple Beers in the repository.
		/// </summary>
		/// <param name="beer">The Beers to upsert.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task UpsertBeersAsync(IEnumerable<Beer> beer);

		/// <summary>
		/// Asynchronously deletes multiple Beers in the repository matching the given identifier.
		/// </summary>
		/// <param name="id">The id of the Beers.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task DeleteBeersAsync(IEnumerable<int> id);
        #endregion

        #region Find Async Methods
		/// <summary>
		/// Asynchronously finds Beers matching a filter object.
		/// </summary>
		/// <param name="filter">The filter to use.</param>
		/// <returns>The selected Beer.</returns>
        Task<IList<Beer>> FindBeersAsync(object filter);
        #endregion
	}
}