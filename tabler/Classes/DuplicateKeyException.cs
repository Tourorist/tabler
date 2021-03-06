﻿using System;

namespace tabler {
    public class DuplicateKeyException : Exception {
        public string KeyName { get; set; }
        public string FileName { get; set; }
        public string EntryName { get; set; }

        public DuplicateKeyException(string keyName) {
            KeyName = keyName;
        }
        public DuplicateKeyException(string keyName, string fileName) {
            KeyName = keyName;
            FileName = fileName;
        }

        public DuplicateKeyException(string keyName, string fileName, string entryName) {
            KeyName = keyName;
            FileName = fileName;
            EntryName = entryName;
        }
    }
}