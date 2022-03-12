using System.Collections.Generic;
using CppSharp.Utils;
using NUnit.Framework;
using CppSharp.AST;
using System.IO;

namespace CppSharp.Generator.Tests
{
    [TestFixture]
    public class ReadNativeSymbolsTest
    {
        [Test]
        public void TestReadSymbolsWindows()
        {
            var symbols = GetSymbols("windows", "libexpat");
            Assert.That(symbols, Is.EquivalentTo(
                new[]
                {
                    "XML_DefaultCurrent",
                    "XML_ErrorString",
                    "XML_ExpatVersion",
                    "XML_ExpatVersionInfo",
                    "XML_ExternalEntityParserCreate",
                    "XML_FreeContentModel",
                    "XML_GetBase",
                    "XML_GetBuffer",
                    "XML_GetCurrentByteCount",
                    "XML_GetCurrentByteIndex",
                    "XML_GetCurrentColumnNumber",
                    "XML_GetCurrentLineNumber",
                    "XML_GetErrorCode",
                    "XML_GetFeatureList",
                    "XML_GetIdAttributeIndex",
                    "XML_GetInputContext",
                    "XML_GetParsingStatus",
                    "XML_GetSpecifiedAttributeCount",
                    "XML_MemFree",
                    "XML_MemMalloc",
                    "XML_MemRealloc",
                    "XML_Parse",
                    "XML_ParseBuffer",
                    "XML_ParserCreate",
                    "XML_ParserCreateNS",
                    "XML_ParserCreate_MM",
                    "XML_ParserFree",
                    "XML_ParserReset",
                    "XML_ResumeParser",
                    "XML_SetAttlistDeclHandler",
                    "XML_SetBase",
                    "XML_SetCdataSectionHandler",
                    "XML_SetCharacterDataHandler",
                    "XML_SetCommentHandler",
                    "XML_SetDefaultHandler",
                    "XML_SetDefaultHandlerExpand",
                    "XML_SetDoctypeDeclHandler",
                    "XML_SetElementDeclHandler",
                    "XML_SetElementHandler",
                    "XML_SetEncoding",
                    "XML_SetEndCdataSectionHandler",
                    "XML_SetEndDoctypeDeclHandler",
                    "XML_SetEndElementHandler",
                    "XML_SetEndNamespaceDeclHandler",
                    "XML_SetEntityDeclHandler",
                    "XML_SetExternalEntityRefHandler",
                    "XML_SetExternalEntityRefHandlerArg",
                    "XML_SetHashSalt",
                    "XML_SetNamespaceDeclHandler",
                    "XML_SetNotStandaloneHandler",
                    "XML_SetNotationDeclHandler",
                    "XML_SetParamEntityParsing",
                    "XML_SetProcessingInstructionHandler",
                    "XML_SetReturnNSTriplet",
                    "XML_SetSkippedEntityHandler",
                    "XML_SetStartCdataSectionHandler",
                    "XML_SetStartDoctypeDeclHandler",
                    "XML_SetStartElementHandler",
                    "XML_SetStartNamespaceDeclHandler",
                    "XML_SetUnknownEncodingHandler",
                    "XML_SetUnparsedEntityDeclHandler",
                    "XML_SetUserData",
                    "XML_SetXmlDeclHandler",
                    "XML_StopParser",
                    "XML_UseForeignDTD",
                    "XML_UseParserAsHandlerArg",
                    "XmlGetUtf16InternalEncoding",
                    "XmlGetUtf16InternalEncodingNS",
                    "XmlGetUtf8InternalEncoding",
                    "XmlGetUtf8InternalEncodingNS",
                    "XmlInitEncoding",
                    "XmlInitEncodingNS",
                    "XmlInitUnknownEncoding",
                    "XmlInitUnknownEncodingNS",
                    "XmlParseXmlDecl",
                    "XmlParseXmlDeclNS",
                    "XmlPrologStateInit",
                    "XmlPrologStateInitExternalEntity",
                    "XmlSizeOfUnknownEncoding",
                    "XmlUtf16Encode",
                    "XmlUtf8Encode",
                    "align_limit_to_full_utf8_characters"
                }));
        }

        [Test]
        public void TestReadSymbolsLinux()
        {
            var symbols = GetSymbols("linux", "libexpat");
            Assert.That(symbols, Is.EquivalentTo(
                new[]
                {
                    ".init",
                    "free",
                    "_ITM_deregisterTMCloneTable",
                    "getpid",
                    "__stack_chk_fail",
                    "gettimeofday",
                    "__assert_fail",
                    "memset",
                    "memcmp",
                    "__gmon_start__",
                    "memcpy",
                    "malloc",
                    "realloc",
                    "memmove",
                    "_Jv_RegisterClasses",
                    "_ITM_registerTMCloneTable",
                    "__cxa_finalize",
                    "XmlInitUnknownEncoding",
                    "XML_FreeContentModel",
                    "XML_SetEndDoctypeDeclHandler",
                    "XML_GetParsingStatus",
                    "XmlGetUtf16InternalEncoding",
                    "XML_MemRealloc",
                    "XmlInitEncoding",
                    "XML_ExpatVersion",
                    "XML_SetHashSalt",
                    "XML_SetStartDoctypeDeclHandler",
                    "XML_ExternalEntityParserCreate",
                    "XML_GetBuffer",
                    "XML_GetCurrentColumnNumber",
                    "XML_SetEndCdataSectionHandler",
                    "XML_SetStartCdataSectionHandler",
                    "XML_GetCurrentByteCount",
                    "XML_DefaultCurrent",
                    "XmlInitUnknownEncodingNS",
                    "XML_ExpatVersionInfo",
                    "XmlUtf16Encode",
                    "XML_GetInputContext",
                    "XML_SetExternalEntityRefHandler",
                    "XML_GetSpecifiedAttributeCount",
                    "XML_SetUserData",
                    "XML_ErrorString",
                    "XML_SetElementHandler",
                    "XML_SetNamespaceDeclHandler",
                    "_fini",
                    "XmlSizeOfUnknownEncoding",
                    "XML_GetIdAttributeIndex",
                    "XML_SetAttlistDeclHandler",
                    "XML_SetReturnNSTriplet",
                    "XML_SetUnknownEncodingHandler",
                    "XML_SetCdataSectionHandler",
                    "XmlParseXmlDeclNS",
                    "XML_SetDoctypeDeclHandler",
                    "XML_SetDefaultHandler",
                    "_init",
                    "XmlPrologStateInitExternalEntity",
                    "XML_SetCharacterDataHandler",
                    "XML_ParserCreate",
                    "XmlGetUtf8InternalEncodingNS",
                    "XML_SetParamEntityParsing",
                    "XML_MemFree",
                    "XML_SetElementDeclHandler",
                    "XML_MemMalloc",
                    "XML_SetStartNamespaceDeclHandler",
                    "XmlGetUtf16InternalEncodingNS",
                    "XML_ParseBuffer",
                    "XML_UseForeignDTD",
                    "XML_SetEncoding",
                    "XML_UseParserAsHandlerArg",
                    "XML_SetEndNamespaceDeclHandler",
                    "XML_SetEndElementHandler",
                    "XML_GetCurrentLineNumber",
                    "XML_SetXmlDeclHandler",
                    "XML_SetProcessingInstructionHandler",
                    "XmlUtf8Encode",
                    "XML_SetStartElementHandler",
                    "XML_SetSkippedEntityHandler",
                    "XML_ResumeParser",
                    "XML_SetEntityDeclHandler",
                    "XML_ParserFree",
                    "XML_SetNotStandaloneHandler",
                    "XML_ParserCreate_MM",
                    "XML_ParserCreateNS",
                    "_edata",
                    "XML_SetUnparsedEntityDeclHandler",
                    "XML_SetBase",
                    "XML_GetBase",
                    "XmlGetUtf8InternalEncoding",
                    "XML_SetExternalEntityRefHandlerArg",
                    "XmlPrologStateInit",
                    "_end",
                    "XML_SetCommentHandler",
                    "XmlParseXmlDecl",
                    "XML_StopParser",
                    "XML_GetErrorCode",
                    "XML_GetFeatureList",
                    "XML_SetDefaultHandlerExpand",
                    "XML_Parse",
                    "XmlInitEncodingNS",
                    "XML_ParserReset",
                    "XML_SetNotationDeclHandler",
                    "__bss_start",
                    "XML_GetCurrentByteIndex"
                }));
        }

        [Test]
        public void TestReadSymbolsMacOS()
        {
            var symbols = GetSymbols("macos", "libexpat");
            Assert.That(symbols, Is.EquivalentTo(
                new[]
                {
                    "_XML_DefaultCurrent",
                    "_XML_ErrorString",
                    "_XML_ExpatVersion",
                    "_XML_ExpatVersionInfo",
                    "_XML_ExternalEntityParserCreate",
                    "_XML_FreeContentModel",
                    "_XML_GetBase",
                    "_XML_GetBuffer",
                    "_XML_GetCurrentByteCount",
                    "_XML_GetCurrentByteIndex",
                    "_XML_GetCurrentColumnNumber",
                    "_XML_GetCurrentLineNumber",
                    "_XML_GetErrorCode",
                    "_XML_GetFeatureList",
                    "_XML_GetIdAttributeIndex",
                    "_XML_GetInputContext",
                    "_XML_GetParsingStatus",
                    "_XML_GetSpecifiedAttributeCount",
                    "_XML_MemFree",
                    "_XML_MemMalloc",
                    "_XML_MemRealloc",
                    "_XML_Parse",
                    "_XML_ParseBuffer",
                    "_XML_ParserCreate",
                    "_XML_ParserCreateNS",
                    "_XML_ParserCreate_MM",
                    "_XML_ParserFree",
                    "_XML_ParserReset",
                    "_XML_ResumeParser",
                    "_XML_SetAttlistDeclHandler",
                    "_XML_SetBase",
                    "_XML_SetCdataSectionHandler",
                    "_XML_SetCharacterDataHandler",
                    "_XML_SetCommentHandler",
                    "_XML_SetDefaultHandler",
                    "_XML_SetDefaultHandlerExpand",
                    "_XML_SetDoctypeDeclHandler",
                    "_XML_SetElementDeclHandler",
                    "_XML_SetElementHandler",
                    "_XML_SetEncoding",
                    "_XML_SetEndCdataSectionHandler",
                    "_XML_SetEndDoctypeDeclHandler",
                    "_XML_SetEndElementHandler",
                    "_XML_SetEndNamespaceDeclHandler",
                    "_XML_SetEntityDeclHandler",
                    "_XML_SetExternalEntityRefHandler",
                    "_XML_SetExternalEntityRefHandlerArg",
                    "_XML_SetHashSalt",
                    "_XML_SetNamespaceDeclHandler",
                    "_XML_SetNotStandaloneHandler",
                    "_XML_SetNotationDeclHandler",
                    "_XML_SetParamEntityParsing",
                    "_XML_SetProcessingInstructionHandler",
                    "_XML_SetReturnNSTriplet",
                    "_XML_SetSkippedEntityHandler",
                    "_XML_SetStartCdataSectionHandler",
                    "_XML_SetStartDoctypeDeclHandler",
                    "_XML_SetStartElementHandler",
                    "_XML_SetStartNamespaceDeclHandler",
                    "_XML_SetUnknownEncodingHandler",
                    "_XML_SetUnparsedEntityDeclHandler",
                    "_XML_SetUserData",
                    "_XML_SetXmlDeclHandler",
                    "_XML_StopParser",
                    "_XML_UseForeignDTD",
                    "_XML_UseParserAsHandlerArg",
                    "_XmlGetUtf16InternalEncoding",
                    "_XmlGetUtf16InternalEncodingNS",
                    "_XmlGetUtf8InternalEncoding",
                    "_XmlGetUtf8InternalEncodingNS",
                    "_XmlInitEncoding",
                    "_XmlInitEncodingNS",
                    "_XmlInitUnknownEncoding",
                    "_XmlInitUnknownEncodingNS",
                    "_XmlParseXmlDecl",
                    "_XmlParseXmlDeclNS",
                    "_XmlPrologStateInit",
                    "_XmlPrologStateInitExternalEntity",
                    "_XmlSizeOfUnknownEncoding",
                    "_XmlUtf16Encode",
                    "_XmlUtf8Encode"
                }));
        }

        private static IList<string> GetSymbols(string dir, string library)
        {
            var driverOptions = new DriverOptions();
            Module module = driverOptions.AddModule("Test");
            module.LibraryDirs.Add(Path.Combine(GeneratorTest.GetTestsDirectory("Native"), dir));
            module.Libraries.Add(library);
            using (var driver = new Driver(driverOptions))
            {
                driver.Setup();
                Assert.IsTrue(driver.ParseLibraries());
                return driver.Context.Symbols.Libraries[0].Symbols;
            }
        }
    }
}
