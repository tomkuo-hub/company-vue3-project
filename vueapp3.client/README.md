題目
從上市公司每月營業收入彙總表 ｜ 政府資料開放平臺，取得資料後，可在前端介面藉由公司代號查詢相關資料。
�垮z應完成各階段實作目標後，再進行加分項及整體軟體架構之調整。
�咱i使用此連結下載 csv 檔，連結失效或其他格式請使用上方連結自行查找。
�姻漸璊閬﹛G請上傳至github個人空間後，再提供連結。

以下是您的必要實作項目：
1.建立資料表、預存程序，
A.必須包含：
�咱媦邽禤おw須為 MSSQL
�姜禤おw專案，包含至少一資料表、兩支預存程序(insert/select)
�姦蚹K被 SQL Injection
B.驗收標準：
�咱媦邽禤おw正確
�姜禤おw欄位完全對標資料來源
�姘w存程序可正常執行
C.加分項：
�咱蕭T建立鍵值
�咱蕭T建立索引
�姜禤ぜx存與原始資料相同


2.建立 API 專案
A.必須包含：
�垂堨� API 專案，目標語言為 .NET6
�型d詢 API * 1、新增資料 API * 1
B.驗收標準：
�隹PI 可被正確執行
�姜禤あ陶Q正確寫入資料庫中
�咧洏峈漸媦郅y言正確
C.加分項：
�咧洏� action filter 來進行全域的錯誤處理或是Log 處理
�咻� swagger 頁面可作查詢
�咧洏� MediatR 來進行中介處理
�咻釣洏� AutoMapper 來進行資料庫物件與輸出物件的轉換



3.建立 Web 專案
A.必須包含：
�垂堨� Web 專案，目標語言為 .NET6
�垂堨葖e端頁面，目標語言為 vue 3(vite)
B.驗收標準：
�垠雁悼蕭T顯示所有查詢後的資訊
�咧洏峈漸媦郅y言正確
C.加分項：
�咩鋮鴞X適的場景使用 vue 的各類基礎語法，例如：computed、v-bind、v-on、v-if/v-show、v-for、watch
這是一個範例：總資料筆數透過 computed 來進行呈現
這是另一個範例：取得 營業收入-去年同月增減(%) 後，使用 computed 四捨五入至小數第二位
�囿鴞葆i入頁面時查詢全部資料，透過生命週期來進行
�咫ㄗ洏峔銗L第三方套件(例如 JQuery 來完成需求)
