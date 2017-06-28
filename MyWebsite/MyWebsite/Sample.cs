using System;

namespace MyWebsite
{
    public interface ISample
    {
        Guid Id { get; }
    }

    public interface ISampleTransient : ISample
    {
    }

    public interface ISampleScoped : ISample
    {
    }

    public interface ISampleSingleton : ISample
    {
    }

    public class Sample : ISampleTransient, ISampleScoped, ISampleSingleton
    {
        private Guid _id;

        public Sample()
        {
            _id = Guid.NewGuid();
        }

        public Guid Id => _id;
    }

    public class SampleService
    {
        public ISampleTransient SampleTransient { get; private set; }
        public ISampleScoped SampleScoped { get; private set; }
        public ISampleSingleton SampleSingleton { get; private set; }

        public SampleService(ISampleTransient sampleTransient, ISampleScoped sampleScoped, ISampleSingleton sampleSingleton)
        {
            SampleTransient = sampleTransient;
            SampleScoped = sampleScoped;
            SampleSingleton = sampleSingleton;
        }
    }
}