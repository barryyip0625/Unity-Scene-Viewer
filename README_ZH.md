# Unity Scene Viewer

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

一個簡單的 Unity 編輯器擴充工具，幫助你快速瀏覽、定位並開啟專案中的場景。  
此工具特別適合擁有大量場景的專案，讓場景管理更加高效。

![Screenshot 2025-05-21 154055](https://github.com/user-attachments/assets/2a20adef-8cfc-47fd-b6ea-99c509c973df)


## 功能特色

- **場景清單瀏覽器：** 列出 `Assets/` 資料夾下的所有場景（不包含套件場景）。
- **快速開啟：** 點擊場景名稱即可開啟（會提示是否儲存當前變更）。
- **加成開啟：** 使用「Add」按鈕可加成載入場景。
- **定位場景：** 當你互動時，自動在 Project 視窗中高亮顯示該場景資產。
- **刷新：** 一鍵刷新以更新場景清單。

## 安裝方式

1. 將 `Editor/SceneViewer/SceneViewer.cs` 檔案（及資料夾）複製到你的 Unity 專案的 `Assets/Editor/` 目錄下。
2. 開啟 Unity。該工具會出現在選單：  
   `Tools > BY Utils > Scene Viewer`

## 使用說明

1. 從選單開啟場景瀏覽器視窗：  
   `Tools > BY Utils > Scene Viewer`
2. 視窗會顯示專案中找到的所有場景。
3. 點擊場景名稱可單一模式開啟，或點擊「Add」以加成方式開啟。
4. 若在視窗開啟期間有新增或移除場景，請使用「刷新場景清單」按鈕。

## 授權條款

本專案採用 MIT 授權條款，詳情請參閱 [LICENSE](LICENSE) 檔案。

## 貢獻

歡迎提出 Issue 或 Pull Request，你的貢獻將讓這個工具更完善！
