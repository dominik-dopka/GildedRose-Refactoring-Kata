##Lizard before
================================================
  NLOC    CCN   token  PARAM  length  location
------------------------------------------------
       9      1     63      0      12 csharp::ApprovalTest::ThirtyDays@15-26@.\ApprovalTest.cs
       4      1     16      1       4 csharp::GildedRose::GildedRose@8-11@.\GildedRose.cs
      71     19    382      0      75 csharp::GildedRose::UpdateQuality@13-87@.\GildedRose.cs
       7      1     63      0       7 csharp::GildedRoseTest::foo@10-16@.\GildedRoseTest.cs
       4      1     22      0       4 csharp::Item::ToString@9-12@.\Item.cs
      42      3    260      1      47 csharp::Program::Main@8-54@.\Program.cs
6 file analyzed.
==============================================================
NLOC    Avg.NLOC  AvgCCN  Avg.token  function_cnt    file
--------------------------------------------------------------
     15       0.0     0.0        0.0         0     .\Properties\AssemblyInfo.cs
     24       9.0     1.0       63.0         1     .\ApprovalTest.cs
     83      37.5    10.0      199.0         2     .\GildedRose.cs
     17       7.0     1.0       63.0         1     .\GildedRoseTest.cs
     13       4.0     1.0       22.0         1     .\Item.cs
     50      42.0     3.0      260.0         1     .\Program.cs

=========================================================================================
!!!! Warnings (cyclomatic_complexity > 15 or length > 1000 or parameter_count > 100) !!!!
================================================
  NLOC    CCN   token  PARAM  length  location
------------------------------------------------
      71     19    382      0      75 csharp::GildedRose::UpdateQuality@13-87@.\GildedRose.cs
==========================================================================================
Total nloc   Avg.NLOC  AvgCCN  Avg.token   Fun Cnt  Warning cnt   Fun Rt   nloc Rt
------------------------------------------------------------------------------------------
       202      22.8     4.3      134.3        6            1      0.17    0.52


##Lizard after
================================================
  NLOC    CCN   token  PARAM  length  location
------------------------------------------------
       7      1     34      1       8 csharpcore.Items::AgedItem::AgedItem@12-19@.\Items\AgedItem.cs
       9      3     30      1       9 csharpcore.Items::AgedItem::QualityRangeCheck@21-29@.\Items\AgedItem.cs
       9      2     30      0      11 csharpcore.Items::AgedItem::UpdateQuality@31-41@.\Items\AgedItem.cs
       5      1     17      0       5 csharpcore.Items::AgedItem::UpdateItemValues@43-47@.\Items\AgedItem.cs
       7      1     34      1       8 csharpcore.Items::BackstagePassItem::BackstagePassItem@12-19@.\Items\BackstagePassItem.cs
       9      3     30      1       9 csharpcore.Items::BackstagePassItem::QualityRangeCheck@21-29@.\Items\BackstagePassItem.cs
      13      4     52      0      15 csharpcore.Items::BackstagePassItem::UpdateQuality@31-45@.\Items\BackstagePassItem.cs
       5      1     17      0       5 csharpcore.Items::BackstagePassItem::UpdateItemValues@47-51@.\Items\BackstagePassItem.cs
       7      1     34      1       8 csharpcore.Items::ConjuredItem::ConjuredItem@11-18@.\Items\ConjuredItem.cs
       9      3     30      1       9 csharpcore.Items::ConjuredItem::QualityRangeCheck@20-28@.\Items\ConjuredItem.cs
       9      2     32      0      11 csharpcore.Items::ConjuredItem::UpdateQuality@30-40@.\Items\ConjuredItem.cs
       5      1     17      0       5 csharpcore.Items::ConjuredItem::UpdateItemValues@42-46@.\Items\ConjuredItem.cs
       7      1     34      1       8 csharpcore.Items::RegularItem::RegularItem@12-19@.\Items\RegularItem.cs
       9      3     30      1       9 csharpcore.Items::RegularItem::QualityRangeCheck@21-29@.\Items\RegularItem.cs
       9      2     32      0      11 csharpcore.Items::RegularItem::UpdateQuality@31-41@.\Items\RegularItem.cs
       5      1     17      0       5 csharpcore.Items::RegularItem::UpdateItemValues@43-47@.\Items\RegularItem.cs
       7      1     29      1       8 csharpcore.Items::SulfurasItem::SulfurasItem@12-19@.\Items\SulfurasItem.cs
       4      1      9      0       4 csharpcore.Items::SulfurasItem::UpdateQuality@21-24@.\Items\SulfurasItem.cs
       5      1     17      0       5 csharpcore.Items::SulfurasItem::UpdateItemValues@26-30@.\Items\SulfurasItem.cs
      17      5    138      1      18 csharpcore::GildedRose::GildedRose@17-34@.\GildedRose.cs
       8      1    110      0       8 csharpcore::GildedRose::UpdateQuality@36-43@.\GildedRose.cs
       9      2     86      4      11 csharpcore::GildedRoseTest::ExecuteUpdate@8-18@.\GildedRoseTest.cs
      14      1    123      0      19 csharpcore::GildedRoseTest::TestOfItemQualityNeverNegative@21-39@.\GildedRoseTest.cs
       9      1     65      0      13 csharpcore::GildedRoseTest::TestRegularItems@42-54@.\GildedRoseTest.cs
       9      1     65      0      13 csharpcore::GildedRoseTest::TestAgedItems@57-69@.\GildedRoseTest.cs
       9      1     65      0      13 csharpcore::GildedRoseTest::TestConjuredItems@72-84@.\GildedRoseTest.cs
      18      1    167      0      28 csharpcore::GildedRoseTest::TestBackstagePassItems@87-114@.\GildedRoseTest.cs
      10      1     76      0      14 csharpcore::GildedRoseTest::TestSulfurasItems@117-130@.\GildedRoseTest.cs
      16      3    122      1      19 csharpcore::Program::Main@36-54@.\Program.cs
12 file analyzed.
==============================================================
NLOC    Avg.NLOC  AvgCCN  Avg.token  function_cnt    file
--------------------------------------------------------------
     41       7.5     1.8       27.8         4     .\Items\AgedItem.cs
     45       8.5     2.2       33.2         4     .\Items\BackstagePassItem.cs
     41       7.5     1.8       28.2         4     .\Items\ConjuredItem.cs
     11       0.0     0.0        0.0         0     .\Items\ICustomItem.cs
     41       7.5     1.8       28.2         4     .\Items\RegularItem.cs
     27       5.3     1.0       18.3         3     .\Items\SulfurasItem.cs
      9       0.0     0.0        0.0         0     .\obj\Debug\netcoreapp2.1\csharpcore.AssemblyInfo.cs
      9       0.0     0.0        0.0         0     .\obj\Debug\netcoreapp2.1\csharpcore.Program.cs
     40      12.5     3.0      124.0         2     .\GildedRose.cs
     92      11.1     1.1       92.4         7     .\GildedRoseTest.cs
      9       0.0     0.0        0.0         0     .\Item.cs
     50      16.0     3.0      122.0         1     .\Program.cs

=============================================================================================
No thresholds exceeded (cyclomatic_complexity > 15 or length > 1000 or parameter_count > 100)
==========================================================================================
Total nloc   Avg.NLOC  AvgCCN  Avg.token   Fun Cnt  Warning cnt   Fun Rt   nloc Rt
------------------------------------------------------------------------------------------
       415       8.9     1.7       53.2       29            0      0.00    0.00