# dev-repo-template

開発プロジェクトで利用するための最小構成リポジトリテンプレート。

## 目的

開発プロジェクトの標準化と立ち上げ高速化

## 使い方

1. GitHub上で`Use this template`で新規レポジトリ作成
2. GitHub上で初期設定
   1. デフォルトブランチを既存`develop`に変更
   2. マージ設定を変更
      - `Allow merge commits`をOFF
      - `Allow squash merging`をON
      - `Allow rebase merging`をOFF
   3. ラベルの修正
      - `bug`：不具合修正
      - `feature`：新機能追加や機能改善
      - `refactor`：既存実装や構成の改善
      - `task`：定型作業やその他の対応タスク
3. cloneしてローカルで初期設定
   1. README修正（プロジェクト固有の内容に書き換え）
   2. GitFlow初期化（`git flow init`）
4. 開発開始

## このテンプレートに含まれているもの

- 基本的なディレクトリ（`src`、`docs`、`scripts`、`tests`）
- イシューテンプレート（`.github/ISSUE_TEMPLATE`）
- プルリクエストテンプレート（`.github/PULL_REQUEST_TEMPLATE.md`）

## フォルダー構成の説明

```text
.
├─ .github/
├─ docs/
├─ scripts/
├─ src/
└─ tests/
```

- `.github/`: GitHub運用設定を配置するフォルダー。各種テンプレート。
- `docs/`: 仕様書や運用手順などのドキュメントを配置
- `scripts/`: 開発補助スクリプトを配置
- `src/`: アプリケーション本体コードを配置
- `tests/`: テストコードを配置

## 前提条件

- Git がインストールされていること
- [git-flow](https://github.com/nvie/gitflow) がインストールされていること
- GitHub リポジトリの管理権限があること
