//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class ItemAccountMappingSearchRowBasic
    {
        // TODO: Make this Lazy and Weak referenced so that it can be garbaged collected
        private static readonly Lazy<ColumnFactory> columnFactoryLoader = new Lazy<ColumnFactory>(() => new ColumnFactory());

        public override void SetColumns(string[] columnNames)
        {
            var factory = columnFactoryLoader.Value;
            for (int i = 0; i < columnNames.Length; i++)
            {
                factory.BuildColumn(this, columnNames[i]);
            }
        }

        class ColumnFactory:  ColumnFactory<ItemAccountMappingSearchRowBasic>
        {
            protected override Dictionary<string, Action<ItemAccountMappingSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<ItemAccountMappingSearchRowBasic>> {
                    { "accountingBook", r => r.@accountingBook = new [] { new SearchColumnSelectField { customLabel = "accountingBook" } } },
                    { "class", r => r.@class = new [] { new SearchColumnSelectField { customLabel = "class" } } },
                   // NOTE: 'customDimension' is unsupported as it's of type SearchColumnSelectCustomField, 
                   // which is not a SearchColumnField type. 
                    { "department", r => r.@department = new [] { new SearchColumnSelectField { customLabel = "department" } } },
                    { "destinationAccount", r => r.@destinationAccount = new [] { new SearchColumnSelectField { customLabel = "destinationAccount" } } },
                    { "effectiveDate", r => r.@effectiveDate = new [] { new SearchColumnDateField { customLabel = "effectiveDate" } } },
                    { "endDate", r => r.@endDate = new [] { new SearchColumnDateField { customLabel = "endDate" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "itemAccount", r => r.@itemAccount = new [] { new SearchColumnEnumSelectField { customLabel = "itemAccount" } } },
                    { "location", r => r.@location = new [] { new SearchColumnSelectField { customLabel = "location" } } },
                    { "sourceAccount", r => r.@sourceAccount = new [] { new SearchColumnSelectField { customLabel = "sourceAccount" } } },
                    { "subsidiary", r => r.@subsidiary = new [] { new SearchColumnSelectField { customLabel = "subsidiary" } } },
                };
            }
        }
    }
}