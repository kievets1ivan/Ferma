using DAL;
using DAL.Entities;
using Ferma_DAL_Tests;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    [Author("Kievets", "dsadas@mail.net")]
    [Category("Repo-tests")]
    public class FermaRepositoryTests
    {
        private UnitOfWork _unitOfWork;
        private static List<FermaEntity> _farms;
        private FermaRepository _fermaRepository;

        public void Init()
        {

        }


        [SetUp]
        public void Setup()
        {
            _farms = new List<FermaEntity>
        {
            new FermaEntity
            {
                Id = Faker.NumberFaker.Number(0, 100),
                AmountOfAnimals = Faker.NumberFaker.Number(0, 100),
                Name = Faker.CompanyFaker.Name(),
                OwnerName = Faker.NameFaker.MaleName(),
                IsDelete = false
            }
        };
            var mockedDbContext = new Mock<FermaContext>();

            mockedDbContext.Setup(x => x.FermaEntities)
                .Returns(() => new FakeDbSet<FermaEntity>(_farms));

            _unitOfWork = new UnitOfWork(mockedDbContext.Object);


            _fermaRepository = new FermaRepository(mockedDbContext.Object);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}