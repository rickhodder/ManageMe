﻿using ManageMe.Core.Entities;
using ManageMe.UnitTests;
using System;
using Xunit;

namespace ManageMe.IntegrationTests.Data
{
    public class EfRepositoryDelete : BaseEfRepoTestFixture
    {
        [Fact]
        public void DeletesItemAfterAddingIt()
        {
            // add an item
            var repository = GetRepository();
            var initialTitle = Guid.NewGuid().ToString();
            var item = new ToDoItemBuilder().Title(initialTitle).Build();
            repository.Add(item);

            // delete the item
            repository.Delete(item);

            // verify it's no longer there
            Assert.DoesNotContain(repository.List<ToDoItem>(),
                i => i.Title == initialTitle);
        }
    }
}