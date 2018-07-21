using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Hotsapi.Uploader.Common
{
    public class FakeUploader: Uploader
    {

        public override Task<int> GetMinimumBuild()
        {
            return Task.FromResult(43905);
        }

        public override async Task Upload(ReplayFile file)
        {
            Random random = new Random();
            file.UploadStatus = UploadStatus.InProgress;
            var task = Task.Delay(1000 + StaticRandom.Rand(1000));

            List<UploadStatus> applicableStatuses = new List<UploadStatus> {
                UploadStatus.AiDetected,
                UploadStatus.Success,
                UploadStatus.Success,
                UploadStatus.Success,
                UploadStatus.Success,
                UploadStatus.Success,
                UploadStatus.Success,
                UploadStatus.CustomGame,
                UploadStatus.Duplicate,
                UploadStatus.Incomplete,
                UploadStatus.PtrRegion,
                UploadStatus.TooOld,
                UploadStatus.UploadError
            };

            await task;
            UploadStatus randomStatus = applicableStatuses[StaticRandom.Rand(applicableStatuses.Count)];
            file.UploadStatus = randomStatus;
        }
    }

    public static class StaticRandom
    {
        static int seed = Environment.TickCount;

        static readonly ThreadLocal<Random> random =
            new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref seed)));

        public static int Rand(int i)
        {
            return random.Value.Next(i);
        }
    }
}