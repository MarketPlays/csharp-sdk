# Intrinio.SDK.Api.TechnicalApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSecurityPriceTechnicalsAdi**](TechnicalApi.md#getsecuritypricetechnicalsadi) | **GET** /securities/{identifier}/prices/technicals/adi | Accumulation/Distribution Index
[**GetSecurityPriceTechnicalsAdtv**](TechnicalApi.md#getsecuritypricetechnicalsadtv) | **GET** /securities/{identifier}/prices/technicals/adtv | Average Daily Trading Volume
[**GetSecurityPriceTechnicalsAdx**](TechnicalApi.md#getsecuritypricetechnicalsadx) | **GET** /securities/{identifier}/prices/technicals/adx | Average Directional Index
[**GetSecurityPriceTechnicalsAo**](TechnicalApi.md#getsecuritypricetechnicalsao) | **GET** /securities/{identifier}/prices/technicals/ao | Awesome Oscillator
[**GetSecurityPriceTechnicalsAtr**](TechnicalApi.md#getsecuritypricetechnicalsatr) | **GET** /securities/{identifier}/prices/technicals/atr | Average True Range
[**GetSecurityPriceTechnicalsBb**](TechnicalApi.md#getsecuritypricetechnicalsbb) | **GET** /securities/{identifier}/prices/technicals/bb | Bollinger Bands
[**GetSecurityPriceTechnicalsCci**](TechnicalApi.md#getsecuritypricetechnicalscci) | **GET** /securities/{identifier}/prices/technicals/cci | Commodity Channel Index
[**GetSecurityPriceTechnicalsCmf**](TechnicalApi.md#getsecuritypricetechnicalscmf) | **GET** /securities/{identifier}/prices/technicals/cmf | Chaikin Money Flow
[**GetSecurityPriceTechnicalsDc**](TechnicalApi.md#getsecuritypricetechnicalsdc) | **GET** /securities/{identifier}/prices/technicals/dc | Donchian Channel
[**GetSecurityPriceTechnicalsDpo**](TechnicalApi.md#getsecuritypricetechnicalsdpo) | **GET** /securities/{identifier}/prices/technicals/dpo | Detrended Price Oscillator
[**GetSecurityPriceTechnicalsEom**](TechnicalApi.md#getsecuritypricetechnicalseom) | **GET** /securities/{identifier}/prices/technicals/eom | Ease of Movement
[**GetSecurityPriceTechnicalsFi**](TechnicalApi.md#getsecuritypricetechnicalsfi) | **GET** /securities/{identifier}/prices/technicals/fi | Force Index
[**GetSecurityPriceTechnicalsIchimoku**](TechnicalApi.md#getsecuritypricetechnicalsichimoku) | **GET** /securities/{identifier}/prices/technicals/ichimoku | Ichimoku Kinko Hyo
[**GetSecurityPriceTechnicalsKc**](TechnicalApi.md#getsecuritypricetechnicalskc) | **GET** /securities/{identifier}/prices/technicals/kc | Keltner Channel
[**GetSecurityPriceTechnicalsKst**](TechnicalApi.md#getsecuritypricetechnicalskst) | **GET** /securities/{identifier}/prices/technicals/kst | Know Sure Thing
[**GetSecurityPriceTechnicalsMacd**](TechnicalApi.md#getsecuritypricetechnicalsmacd) | **GET** /securities/{identifier}/prices/technicals/macd | Moving Average Convergence Divergence
[**GetSecurityPriceTechnicalsMfi**](TechnicalApi.md#getsecuritypricetechnicalsmfi) | **GET** /securities/{identifier}/prices/technicals/mfi | Money Flow Index
[**GetSecurityPriceTechnicalsMi**](TechnicalApi.md#getsecuritypricetechnicalsmi) | **GET** /securities/{identifier}/prices/technicals/mi | Mass Index
[**GetSecurityPriceTechnicalsNvi**](TechnicalApi.md#getsecuritypricetechnicalsnvi) | **GET** /securities/{identifier}/prices/technicals/nvi | Negative Volume Index
[**GetSecurityPriceTechnicalsObv**](TechnicalApi.md#getsecuritypricetechnicalsobv) | **GET** /securities/{identifier}/prices/technicals/obv | On-balance Volume
[**GetSecurityPriceTechnicalsObvMean**](TechnicalApi.md#getsecuritypricetechnicalsobvmean) | **GET** /securities/{identifier}/prices/technicals/obv_mean | On-balance Volume Mean
[**GetSecurityPriceTechnicalsRsi**](TechnicalApi.md#getsecuritypricetechnicalsrsi) | **GET** /securities/{identifier}/prices/technicals/rsi | Relative Strength Index
[**GetSecurityPriceTechnicalsSma**](TechnicalApi.md#getsecuritypricetechnicalssma) | **GET** /securities/{identifier}/prices/technicals/sma | Simple Moving Average
[**GetSecurityPriceTechnicalsSr**](TechnicalApi.md#getsecuritypricetechnicalssr) | **GET** /securities/{identifier}/prices/technicals/sr | Stochastic Oscillator
[**GetSecurityPriceTechnicalsTrix**](TechnicalApi.md#getsecuritypricetechnicalstrix) | **GET** /securities/{identifier}/prices/technicals/trix | Triple Exponential Average
[**GetSecurityPriceTechnicalsTsi**](TechnicalApi.md#getsecuritypricetechnicalstsi) | **GET** /securities/{identifier}/prices/technicals/tsi | True Strength Index
[**GetSecurityPriceTechnicalsUo**](TechnicalApi.md#getsecuritypricetechnicalsuo) | **GET** /securities/{identifier}/prices/technicals/uo | Ultimate Oscillator
[**GetSecurityPriceTechnicalsVi**](TechnicalApi.md#getsecuritypricetechnicalsvi) | **GET** /securities/{identifier}/prices/technicals/vi | Vortex Indicator
[**GetSecurityPriceTechnicalsVpt**](TechnicalApi.md#getsecuritypricetechnicalsvpt) | **GET** /securities/{identifier}/prices/technicals/vpt | Volume-price Trend
[**GetSecurityPriceTechnicalsVwap**](TechnicalApi.md#getsecuritypricetechnicalsvwap) | **GET** /securities/{identifier}/prices/technicals/vwap | Volume Weighted Average Price
[**GetSecurityPriceTechnicalsWr**](TechnicalApi.md#getsecuritypricetechnicalswr) | **GET** /securities/{identifier}/prices/technicals/wr | Williams %R


<a name="getsecuritypricetechnicalsadi"></a>
# **GetSecurityPriceTechnicalsAdi**
> ApiResponseSecurityAccumulationDistributionIndex GetSecurityPriceTechnicalsAdi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Accumulation/Distribution Index

Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsAdiExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityAccumulationDistributionIndex result = technicalApi.GetSecurityPriceTechnicalsAdi(identifier, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsAdi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityAccumulationDistributionIndex**](ApiResponseSecurityAccumulationDistributionIndex.md)

<a name="getsecuritypricetechnicalsadtv"></a>
# **GetSecurityPriceTechnicalsAdtv**
> ApiResponseSecurityAverageDailyTradingVolume GetSecurityPriceTechnicalsAdtv (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Average Daily Trading Volume

Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsAdtvExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 22;  // int? | The number of observations, per period, to calculate Average Daily Trading Volume (optional)  (default to 22)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityAverageDailyTradingVolume result = technicalApi.GetSecurityPriceTechnicalsAdtv(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsAdtv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Average Daily Trading Volume | [optional] [default to 22]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityAverageDailyTradingVolume**](ApiResponseSecurityAverageDailyTradingVolume.md)

<a name="getsecuritypricetechnicalsadx"></a>
# **GetSecurityPriceTechnicalsAdx**
> ApiResponseSecurityAverageDirectionalIndex GetSecurityPriceTechnicalsAdx (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Average Directional Index

Returns the Average Directional Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsAdxExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 14;  // int? | The number of observations, per period, to calculate Average Directional Index (optional)  (default to 14)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityAverageDirectionalIndex result = technicalApi.GetSecurityPriceTechnicalsAdx(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsAdx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Average Directional Index | [optional] [default to 14]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityAverageDirectionalIndex**](ApiResponseSecurityAverageDirectionalIndex.md)

<a name="getsecuritypricetechnicalsao"></a>
# **GetSecurityPriceTechnicalsAo**
> ApiResponseSecurityAwesomeOscillator GetSecurityPriceTechnicalsAo (string identifier, int? shortPeriod = null, int? longPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Awesome Oscillator

Returns the Awesome Oscillator values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsAoExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var shortPeriod = 5;  // int? | The number of observations, per period, to calculate short period Simple Moving Average of the Awesome Oscillator (optional)  (default to 5)
            var longPeriod = 34;  // int? | The number of observations, per period, to calculate long period Simple Moving Average of the Awesome Oscillator (optional)  (default to 34)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityAwesomeOscillator result = technicalApi.GetSecurityPriceTechnicalsAo(identifier, shortPeriod, longPeriod, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsAo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **shortPeriod** | **int?**| The number of observations, per period, to calculate short period Simple Moving Average of the Awesome Oscillator | [optional] [default to 5]
 **longPeriod** | **int?**| The number of observations, per period, to calculate long period Simple Moving Average of the Awesome Oscillator | [optional] [default to 34]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityAwesomeOscillator**](ApiResponseSecurityAwesomeOscillator.md)

<a name="getsecuritypricetechnicalsatr"></a>
# **GetSecurityPriceTechnicalsAtr**
> ApiResponseSecurityAverageTrueRange GetSecurityPriceTechnicalsAtr (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Average True Range

Returns the Average True Range values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsAtrExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 14;  // int? | The number of observations, per period, to calculate Average True Range (optional)  (default to 14)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityAverageTrueRange result = technicalApi.GetSecurityPriceTechnicalsAtr(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsAtr: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Average True Range | [optional] [default to 14]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityAverageTrueRange**](ApiResponseSecurityAverageTrueRange.md)

<a name="getsecuritypricetechnicalsbb"></a>
# **GetSecurityPriceTechnicalsBb**
> ApiResponseSecurityBollingerBands GetSecurityPriceTechnicalsBb (string identifier, int? period = null, float? standardDeviations = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Bollinger Bands

Returns the Bollinger Bands values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsBbExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 20;  // int? | The number of observations, per period, to calculate Bollinger Bands (optional)  (default to 20)
            var standardDeviations = 2.0;  // float? | The number of standard deviations to calculate the upper and lower bands of the Bollinger Bands (optional)  (default to 2.0)
            var priceKey = "close";  // string | The Stock Price field to use when calculating Bollinger Bands (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityBollingerBands result = technicalApi.GetSecurityPriceTechnicalsBb(identifier, period, standardDeviations, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsBb: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Bollinger Bands | [optional] [default to 20]
 **standardDeviations** | **float?**| The number of standard deviations to calculate the upper and lower bands of the Bollinger Bands | [optional] [default to 2.0]
 **priceKey** | **string**| The Stock Price field to use when calculating Bollinger Bands | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityBollingerBands**](ApiResponseSecurityBollingerBands.md)

<a name="getsecuritypricetechnicalscci"></a>
# **GetSecurityPriceTechnicalsCci**
> ApiResponseSecurityCommodityChannelIndex GetSecurityPriceTechnicalsCci (string identifier, int? period = null, float? constant = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Commodity Channel Index

Returns the Commodity Channel Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsCciExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 20;  // int? | The number of observations, per period, to calculate Commodity Channel Index (optional)  (default to 20)
            var constant = 0.015;  // float? | The number of observations, per period, to calculate Commodity Channel Index (optional)  (default to 0.015)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityCommodityChannelIndex result = technicalApi.GetSecurityPriceTechnicalsCci(identifier, period, constant, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsCci: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Commodity Channel Index | [optional] [default to 20]
 **constant** | **float?**| The number of observations, per period, to calculate Commodity Channel Index | [optional] [default to 0.015]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityCommodityChannelIndex**](ApiResponseSecurityCommodityChannelIndex.md)

<a name="getsecuritypricetechnicalscmf"></a>
# **GetSecurityPriceTechnicalsCmf**
> ApiResponseSecurityChaikinMoneyFlow GetSecurityPriceTechnicalsCmf (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Chaikin Money Flow

Returns the Chaikin Money Flow values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsCmfExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 20;  // int? | The number of observations, per period, to calculate Chaikin Money Flow (optional)  (default to 20)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityChaikinMoneyFlow result = technicalApi.GetSecurityPriceTechnicalsCmf(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsCmf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Chaikin Money Flow | [optional] [default to 20]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityChaikinMoneyFlow**](ApiResponseSecurityChaikinMoneyFlow.md)

<a name="getsecuritypricetechnicalsdc"></a>
# **GetSecurityPriceTechnicalsDc**
> ApiResponseSecurityDonchianChannel GetSecurityPriceTechnicalsDc (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Donchian Channel

Returns the Donchian Channel values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsDcExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 20;  // int? | The number of observations, per period, to calculate Donchian Channel (optional)  (default to 20)
            var priceKey = "close";  // string | The Stock Price field to use when calculating Donchian Channel (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityDonchianChannel result = technicalApi.GetSecurityPriceTechnicalsDc(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsDc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Donchian Channel | [optional] [default to 20]
 **priceKey** | **string**| The Stock Price field to use when calculating Donchian Channel | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityDonchianChannel**](ApiResponseSecurityDonchianChannel.md)

<a name="getsecuritypricetechnicalsdpo"></a>
# **GetSecurityPriceTechnicalsDpo**
> ApiResponseSecurityDetrendedPriceOscillator GetSecurityPriceTechnicalsDpo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Detrended Price Oscillator

Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsDpoExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 20;  // int? | The number of observations, per period, to calculate Detrended Price Oscillator (optional)  (default to 20)
            var priceKey = "close";  // string | The Stock Price field to use when calculating Detrended Price Oscillator (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityDetrendedPriceOscillator result = technicalApi.GetSecurityPriceTechnicalsDpo(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsDpo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Detrended Price Oscillator | [optional] [default to 20]
 **priceKey** | **string**| The Stock Price field to use when calculating Detrended Price Oscillator | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityDetrendedPriceOscillator**](ApiResponseSecurityDetrendedPriceOscillator.md)

<a name="getsecuritypricetechnicalseom"></a>
# **GetSecurityPriceTechnicalsEom**
> ApiResponseSecurityEaseOfMovement GetSecurityPriceTechnicalsEom (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Ease of Movement

Returns the Ease of Movement values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsEomExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 20;  // int? | The number of observations, per period, to calculate Ease of Movement (optional)  (default to 20)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityEaseOfMovement result = technicalApi.GetSecurityPriceTechnicalsEom(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsEom: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Ease of Movement | [optional] [default to 20]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityEaseOfMovement**](ApiResponseSecurityEaseOfMovement.md)

<a name="getsecuritypricetechnicalsfi"></a>
# **GetSecurityPriceTechnicalsFi**
> ApiResponseSecurityForceIndex GetSecurityPriceTechnicalsFi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Force Index

Returns the Force Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsFiExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityForceIndex result = technicalApi.GetSecurityPriceTechnicalsFi(identifier, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsFi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityForceIndex**](ApiResponseSecurityForceIndex.md)

<a name="getsecuritypricetechnicalsichimoku"></a>
# **GetSecurityPriceTechnicalsIchimoku**
> ApiResponseSecurityIchimokuKinkoHyo GetSecurityPriceTechnicalsIchimoku (string identifier, int? lowPeriod = null, int? mediumPeriod = null, int? highPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Ichimoku Kinko Hyo

Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsIchimokuExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var lowPeriod = 9;  // int? | The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku Kinko Hyo (optional)  (default to 9)
            var mediumPeriod = 26;  // int? | The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo (optional)  (default to 26)
            var highPeriod = 52;  // int? | The number of observations, per period, to calculate Senkou Span B (Leading Span B) of Ichimoku Kinko Hyo (optional)  (default to 52)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityIchimokuKinkoHyo result = technicalApi.GetSecurityPriceTechnicalsIchimoku(identifier, lowPeriod, mediumPeriod, highPeriod, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsIchimoku: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **lowPeriod** | **int?**| The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku Kinko Hyo | [optional] [default to 9]
 **mediumPeriod** | **int?**| The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo | [optional] [default to 26]
 **highPeriod** | **int?**| The number of observations, per period, to calculate Senkou Span B (Leading Span B) of Ichimoku Kinko Hyo | [optional] [default to 52]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityIchimokuKinkoHyo**](ApiResponseSecurityIchimokuKinkoHyo.md)

<a name="getsecuritypricetechnicalskc"></a>
# **GetSecurityPriceTechnicalsKc**
> ApiResponseSecurityKeltnerChannel GetSecurityPriceTechnicalsKc (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Keltner Channel

Returns the Keltner Channel values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsKcExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 10;  // int? | The number of observations, per period, to calculate Kelter Channel (optional)  (default to 10)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityKeltnerChannel result = technicalApi.GetSecurityPriceTechnicalsKc(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsKc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Kelter Channel | [optional] [default to 10]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityKeltnerChannel**](ApiResponseSecurityKeltnerChannel.md)

<a name="getsecuritypricetechnicalskst"></a>
# **GetSecurityPriceTechnicalsKst**
> ApiResponseSecurityKnowSureThing GetSecurityPriceTechnicalsKst (string identifier, int? roc1 = null, int? roc2 = null, int? roc3 = null, int? roc4 = null, int? roc5 = null, int? sma1 = null, int? sma2 = null, int? sma3 = null, int? sma4 = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Know Sure Thing

Returns the Know Sure Thing values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsKstExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var roc1 = 10;  // int? | The number of observations, per period, to calculate the rate-of-change for RCMA1 (optional)  (default to 10)
            var roc2 = 15;  // int? | The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional)  (default to 15)
            var roc3 = 15;  // int? | The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional)  (default to 15)
            var roc4 = 20;  // int? | The number of observations, per period, to calculate the rate-of-change for RCMA3 (optional)  (default to 20)
            var roc5 = 30;  // int? | The number of observations, per period, to calculate the rate-of-change for RCMA4 (optional)  (default to 30)
            var sma1 = 10;  // int? | The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA1 (optional)  (default to 10)
            var sma2 = 10;  // int? | The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA2 (optional)  (default to 10)
            var sma3 = 10;  // int? | The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA3 (optional)  (default to 10)
            var sma4 = 15;  // int? | The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA4 (optional)  (default to 15)
            var priceKey = "close";  // string | The Stock Price field to use when calculating Know Sure Thing (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityKnowSureThing result = technicalApi.GetSecurityPriceTechnicalsKst(identifier, roc1, roc2, roc3, roc4, roc5, sma1, sma2, sma3, sma4, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsKst: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **roc1** | **int?**| The number of observations, per period, to calculate the rate-of-change for RCMA1 | [optional] [default to 10]
 **roc2** | **int?**| The number of observations, per period, to calculate the rate-of-change for RCMA2 | [optional] [default to 15]
 **roc3** | **int?**| The number of observations, per period, to calculate the rate-of-change for RCMA2 | [optional] [default to 15]
 **roc4** | **int?**| The number of observations, per period, to calculate the rate-of-change for RCMA3 | [optional] [default to 20]
 **roc5** | **int?**| The number of observations, per period, to calculate the rate-of-change for RCMA4 | [optional] [default to 30]
 **sma1** | **int?**| The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA1 | [optional] [default to 10]
 **sma2** | **int?**| The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA2 | [optional] [default to 10]
 **sma3** | **int?**| The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA3 | [optional] [default to 10]
 **sma4** | **int?**| The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA4 | [optional] [default to 15]
 **priceKey** | **string**| The Stock Price field to use when calculating Know Sure Thing | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityKnowSureThing**](ApiResponseSecurityKnowSureThing.md)

<a name="getsecuritypricetechnicalsmacd"></a>
# **GetSecurityPriceTechnicalsMacd**
> ApiResponseSecurityMovingAverageConvergenceDivergence GetSecurityPriceTechnicalsMacd (string identifier, int? fastPeriod = null, int? slowPeriod = null, int? signalPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Moving Average Convergence Divergence

Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsMacdExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var fastPeriod = 12;  // int? | The number of observations, per period, to calculate the fast moving Exponential Moving Average for Moving Average Convergence Divergence (optional)  (default to 12)
            var slowPeriod = 26;  // int? | The number of observations, per period, to calculate the slow moving Exponential Moving Average for Moving Average Convergence Divergence (optional)  (default to 26)
            var signalPeriod = 9;  // int? | The number of observations, per period, to calculate the signal line for Moving Average Convergence Divergence (optional)  (default to 9)
            var priceKey = "close";  // string | The Stock Price field to use when calculating Moving Average Convergence Divergence (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityMovingAverageConvergenceDivergence result = technicalApi.GetSecurityPriceTechnicalsMacd(identifier, fastPeriod, slowPeriod, signalPeriod, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsMacd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **fastPeriod** | **int?**| The number of observations, per period, to calculate the fast moving Exponential Moving Average for Moving Average Convergence Divergence | [optional] [default to 12]
 **slowPeriod** | **int?**| The number of observations, per period, to calculate the slow moving Exponential Moving Average for Moving Average Convergence Divergence | [optional] [default to 26]
 **signalPeriod** | **int?**| The number of observations, per period, to calculate the signal line for Moving Average Convergence Divergence | [optional] [default to 9]
 **priceKey** | **string**| The Stock Price field to use when calculating Moving Average Convergence Divergence | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityMovingAverageConvergenceDivergence**](ApiResponseSecurityMovingAverageConvergenceDivergence.md)

<a name="getsecuritypricetechnicalsmfi"></a>
# **GetSecurityPriceTechnicalsMfi**
> ApiResponseSecurityMoneyFlowIndex GetSecurityPriceTechnicalsMfi (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Money Flow Index

Returns the Money Flow Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsMfiExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 14;  // int? | The number of observations, per period, to calculate Money Flow Index (optional)  (default to 14)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityMoneyFlowIndex result = technicalApi.GetSecurityPriceTechnicalsMfi(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsMfi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Money Flow Index | [optional] [default to 14]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityMoneyFlowIndex**](ApiResponseSecurityMoneyFlowIndex.md)

<a name="getsecuritypricetechnicalsmi"></a>
# **GetSecurityPriceTechnicalsMi**
> ApiResponseSecurityMassIndex GetSecurityPriceTechnicalsMi (string identifier, int? emaPeriod = null, int? sumPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Mass Index

Returns the Mass Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsMiExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var emaPeriod = 9;  // int? | The number of observations, per period, to calculate the single Exponential Moving Average and the Double Exponential Moving Average for Mass Index (optional)  (default to 9)
            var sumPeriod = 25;  // int? | The number of observations, per period, to calculate the sum of the Exponetinal Moving Average Ratios for Mass Index (optional)  (default to 25)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityMassIndex result = technicalApi.GetSecurityPriceTechnicalsMi(identifier, emaPeriod, sumPeriod, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsMi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **emaPeriod** | **int?**| The number of observations, per period, to calculate the single Exponential Moving Average and the Double Exponential Moving Average for Mass Index | [optional] [default to 9]
 **sumPeriod** | **int?**| The number of observations, per period, to calculate the sum of the Exponetinal Moving Average Ratios for Mass Index | [optional] [default to 25]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityMassIndex**](ApiResponseSecurityMassIndex.md)

<a name="getsecuritypricetechnicalsnvi"></a>
# **GetSecurityPriceTechnicalsNvi**
> ApiResponseSecurityNegativeVolumeIndex GetSecurityPriceTechnicalsNvi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Negative Volume Index

Returns the Negative Volume Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsNviExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityNegativeVolumeIndex result = technicalApi.GetSecurityPriceTechnicalsNvi(identifier, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsNvi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityNegativeVolumeIndex**](ApiResponseSecurityNegativeVolumeIndex.md)

<a name="getsecuritypricetechnicalsobv"></a>
# **GetSecurityPriceTechnicalsObv**
> ApiResponseSecurityOnBalanceVolume GetSecurityPriceTechnicalsObv (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

On-balance Volume

Returns the On-balance Volume values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsObvExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityOnBalanceVolume result = technicalApi.GetSecurityPriceTechnicalsObv(identifier, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsObv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityOnBalanceVolume**](ApiResponseSecurityOnBalanceVolume.md)

<a name="getsecuritypricetechnicalsobvmean"></a>
# **GetSecurityPriceTechnicalsObvMean**
> ApiResponseSecurityOnBalanceVolumeMean GetSecurityPriceTechnicalsObvMean (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

On-balance Volume Mean

Returns the On-balance Volume Mean values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsObvMeanExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 10;  // int? | The number of observations, per period, to calculate On-balance Volume Mean (optional)  (default to 10)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityOnBalanceVolumeMean result = technicalApi.GetSecurityPriceTechnicalsObvMean(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsObvMean: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate On-balance Volume Mean | [optional] [default to 10]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityOnBalanceVolumeMean**](ApiResponseSecurityOnBalanceVolumeMean.md)

<a name="getsecuritypricetechnicalsrsi"></a>
# **GetSecurityPriceTechnicalsRsi**
> ApiResponseSecurityRelativeStrengthIndex GetSecurityPriceTechnicalsRsi (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Relative Strength Index

Returns the Relative Strength Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsRsiExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 14;  // int? | The number of observations, per period, to calculate Relative Strength Index (optional)  (default to 14)
            var priceKey = "close";  // string | The Stock Price field to use when calculating Relative Strength Index (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityRelativeStrengthIndex result = technicalApi.GetSecurityPriceTechnicalsRsi(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsRsi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Relative Strength Index | [optional] [default to 14]
 **priceKey** | **string**| The Stock Price field to use when calculating Relative Strength Index | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityRelativeStrengthIndex**](ApiResponseSecurityRelativeStrengthIndex.md)

<a name="getsecuritypricetechnicalssma"></a>
# **GetSecurityPriceTechnicalsSma**
> ApiResponseSecuritySimpleMovingAverage GetSecurityPriceTechnicalsSma (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Simple Moving Average

Returns the Simple Moving Average values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsSmaExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 20;  // int? | The number of observations, per period, to calculate Simple Moving Average (optional)  (default to 20)
            var priceKey = "close";  // string | The Stock Price field to use when calculating Simple Moving Average (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecuritySimpleMovingAverage result = technicalApi.GetSecurityPriceTechnicalsSma(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsSma: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Simple Moving Average | [optional] [default to 20]
 **priceKey** | **string**| The Stock Price field to use when calculating Simple Moving Average | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecuritySimpleMovingAverage**](ApiResponseSecuritySimpleMovingAverage.md)

<a name="getsecuritypricetechnicalssr"></a>
# **GetSecurityPriceTechnicalsSr**
> ApiResponseSecurityStochasticOscillator GetSecurityPriceTechnicalsSr (string identifier, int? period = null, int? signalPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Stochastic Oscillator

Returns the Stochastic Oscillator values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsSrExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 14;  // int? | The number of observations, per period, to calculate %K of Stochastic Oscillator (optional)  (default to 14)
            var signalPeriod = 3;  // int? | The number of observations, per period, to calculate the %D (the Simple Moving Average of %K) as a signal line for Stochastic Oscillator (optional)  (default to 3)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityStochasticOscillator result = technicalApi.GetSecurityPriceTechnicalsSr(identifier, period, signalPeriod, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsSr: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate %K of Stochastic Oscillator | [optional] [default to 14]
 **signalPeriod** | **int?**| The number of observations, per period, to calculate the %D (the Simple Moving Average of %K) as a signal line for Stochastic Oscillator | [optional] [default to 3]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityStochasticOscillator**](ApiResponseSecurityStochasticOscillator.md)

<a name="getsecuritypricetechnicalstrix"></a>
# **GetSecurityPriceTechnicalsTrix**
> ApiResponseSecurityTripleExponentialAverage GetSecurityPriceTechnicalsTrix (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Triple Exponential Average

Returns the Simple Moving Average values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsTrixExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 15;  // int? | The number of observations, per period, to calculate Exponential Moving Average for Triple Exponential Average (optional)  (default to 15)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityTripleExponentialAverage result = technicalApi.GetSecurityPriceTechnicalsTrix(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsTrix: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Exponential Moving Average for Triple Exponential Average | [optional] [default to 15]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityTripleExponentialAverage**](ApiResponseSecurityTripleExponentialAverage.md)

<a name="getsecuritypricetechnicalstsi"></a>
# **GetSecurityPriceTechnicalsTsi**
> ApiResponseSecurityTrueStrengthIndex GetSecurityPriceTechnicalsTsi (string identifier, int? lowPeriod = null, int? highPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

True Strength Index

Returns the True Strength Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsTsiExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var lowPeriod = 13;  // int? | The number of observations, per period, to calculate low period Exponential Moving Average for smoothing in True Strength Index (optional)  (default to 13)
            var highPeriod = 25;  // int? | The number of observations, per period, to calculate high period Exponential Moving Average for smoothing in True Strength Index (optional)  (default to 25)
            var priceKey = "close";  // string | The Stock Price field to use when calculating True Strength Index (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityTrueStrengthIndex result = technicalApi.GetSecurityPriceTechnicalsTsi(identifier, lowPeriod, highPeriod, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsTsi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **lowPeriod** | **int?**| The number of observations, per period, to calculate low period Exponential Moving Average for smoothing in True Strength Index | [optional] [default to 13]
 **highPeriod** | **int?**| The number of observations, per period, to calculate high period Exponential Moving Average for smoothing in True Strength Index | [optional] [default to 25]
 **priceKey** | **string**| The Stock Price field to use when calculating True Strength Index | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityTrueStrengthIndex**](ApiResponseSecurityTrueStrengthIndex.md)

<a name="getsecuritypricetechnicalsuo"></a>
# **GetSecurityPriceTechnicalsUo**
> ApiResponseSecurityUltimateOscillator GetSecurityPriceTechnicalsUo (string identifier, int? shortPeriod = null, int? mediumPeriod = null, int? longPeriod = null, float? shortWeight = null, float? mediumWeight = null, float? longWeight = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Ultimate Oscillator

Returns the Ultimate Oscillator values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsUoExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var shortPeriod = 7;  // int? | The number of observations, per period, to calculate the short period for Ultimate Oscillator (optional)  (default to 7)
            var mediumPeriod = 14;  // int? | The number of observations, per period, to calculate the medium period for Ultimate Oscillator (optional)  (default to 14)
            var longPeriod = 28;  // int? | The number of observations, per period, to calculate the long period for Ultimate Oscillator (optional)  (default to 28)
            var shortWeight = 4.0;  // float? | The weight of short Buying Pressure average for Ultimate Oscillator (optional)  (default to 4.0)
            var mediumWeight = 2.0;  // float? | The weight of medium Buying Pressure average for Ultimate Oscillator (optional)  (default to 2.0)
            var longWeight = 1.0;  // float? | The weight of long Buying Pressure average for Ultimate Oscillator (optional)  (default to 1.0)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityUltimateOscillator result = technicalApi.GetSecurityPriceTechnicalsUo(identifier, shortPeriod, mediumPeriod, longPeriod, shortWeight, mediumWeight, longWeight, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsUo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **shortPeriod** | **int?**| The number of observations, per period, to calculate the short period for Ultimate Oscillator | [optional] [default to 7]
 **mediumPeriod** | **int?**| The number of observations, per period, to calculate the medium period for Ultimate Oscillator | [optional] [default to 14]
 **longPeriod** | **int?**| The number of observations, per period, to calculate the long period for Ultimate Oscillator | [optional] [default to 28]
 **shortWeight** | **float?**| The weight of short Buying Pressure average for Ultimate Oscillator | [optional] [default to 4.0]
 **mediumWeight** | **float?**| The weight of medium Buying Pressure average for Ultimate Oscillator | [optional] [default to 2.0]
 **longWeight** | **float?**| The weight of long Buying Pressure average for Ultimate Oscillator | [optional] [default to 1.0]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityUltimateOscillator**](ApiResponseSecurityUltimateOscillator.md)

<a name="getsecuritypricetechnicalsvi"></a>
# **GetSecurityPriceTechnicalsVi**
> ApiResponseSecurityVortexIndicator GetSecurityPriceTechnicalsVi (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Vortex Indicator

Returns the Vortex Indicator values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsViExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 14;  // int? | The number of observations, per period, to calculate Vortex Indicator (optional)  (default to 14)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityVortexIndicator result = technicalApi.GetSecurityPriceTechnicalsVi(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsVi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Vortex Indicator | [optional] [default to 14]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityVortexIndicator**](ApiResponseSecurityVortexIndicator.md)

<a name="getsecuritypricetechnicalsvpt"></a>
# **GetSecurityPriceTechnicalsVpt**
> ApiResponseSecurityVolumePriceTrend GetSecurityPriceTechnicalsVpt (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Volume-price Trend

Returns the Volume-price Trend values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsVptExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityVolumePriceTrend result = technicalApi.GetSecurityPriceTechnicalsVpt(identifier, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsVpt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityVolumePriceTrend**](ApiResponseSecurityVolumePriceTrend.md)

<a name="getsecuritypricetechnicalsvwap"></a>
# **GetSecurityPriceTechnicalsVwap**
> ApiResponseSecurityVolumeWeightedAveragePrice GetSecurityPriceTechnicalsVwap (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Volume Weighted Average Price

Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsVwapExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityVolumeWeightedAveragePrice result = technicalApi.GetSecurityPriceTechnicalsVwap(identifier, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsVwap: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityVolumeWeightedAveragePrice**](ApiResponseSecurityVolumeWeightedAveragePrice.md)

<a name="getsecuritypricetechnicalswr"></a>
# **GetSecurityPriceTechnicalsWr**
> ApiResponseSecurityWilliamsR GetSecurityPriceTechnicalsWr (string identifier, int? period = null, string startDate = null, string endDate = null, decimal? pageSize = null, string nextPage = null)

Williams %R

Returns the Williams %R values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsWrExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var technicalApi = new TechnicalApi();
            var identifier = "$$v2_ticker_default$$";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 14;  // int? | The number of observations, per period, to look-back when calculating Williams %R (optional)  (default to 14)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityWilliamsR result = technicalApi.GetSecurityPriceTechnicalsWr(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnicalApi.GetSecurityPriceTechnicalsWr: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to look-back when calculating Williams %R | [optional] [default to 14]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityWilliamsR**](ApiResponseSecurityWilliamsR.md)
