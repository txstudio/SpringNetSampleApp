
# 使用 Spring 框架進行 Dependency Injection 的範例

## 環境

- .NET Framework 4.5.1
- Spring.Core 2.0.1

## 情境

透過抽離 DateTime 介面依 App.config 進行不同的注入實作

```
<spring>
	<context>
		<resource uri="config://spring/objects"/>
	</context>
	<objects xmlns="http://www.springframework.net">
		<!-- 取消註解來指定 IDateTime 介面的實作物件 -->
		<!-- 
		<object name="InjectDateTime" type="SpringNetSampleApp.BirthDateTime, SpringNetSampleApp"></object>
		<object name="InjectDateTime" type="SpringNetSampleApp.UtcDateTime, SpringNetSampleApp"></object>
		<object name="InjectDateTime" type="SpringNetSampleApp.LocalDateTime, SpringNetSampleApp"></object>
		 -->
	</objects>
</spring>
```

執行後就可以看到主控台輸出結果