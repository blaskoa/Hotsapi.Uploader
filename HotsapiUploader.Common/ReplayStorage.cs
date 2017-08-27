﻿using HotsapiUploader.Common;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace HotsapiUploader.Common
{
    public class ReplayStorage : IReplayStorage
    {
        private static Logger _log = LogManager.GetCurrentClassLogger();
        private readonly string _filename;

        public ReplayStorage(string filename)
        {
            _filename = filename;
        }

        public IEnumerable<ReplayFile> Load()
        {
            if (!File.Exists(_filename)) {
                return new ReplayFile[0];
            }

            try {
                using (var f = File.OpenRead(_filename)) {
                    var serializer = new XmlSerializer(typeof(ReplayFile[]));
                    return (ReplayFile[])serializer.Deserialize(f);
                }
            }
            catch (Exception ex) {
                _log.Error(ex, "Error loading replay upload data");
                return new ReplayFile[0];
            }
        }

        public void Save(IEnumerable<ReplayFile> files)
        {
            try {                
                using (var stream = new MemoryStream()) {
                    var data = files.ToArray();
                    var serializer = new XmlSerializer(data.GetType());
                    serializer.Serialize(stream, data);
                    File.WriteAllBytes(_filename, stream.ToArray());
                }
            }
            catch (Exception ex) {
                _log.Error(ex, "Error saving replay upload data");
            }
        }
    }
}
