## 光を走らせる

主にシェーダを使ってループアニメーションを実装します。

![結果画像1](result1_1.gif)

![結果画像2](result1_2.gif)

![結果画像3](result1_3.gif)

![結果画像](result1_4.gif)

https://github.com/simulacru/test/assets/104343269/dd9661e9-c317-44be-8166-c454531fd474

![シェーダグラフ](node_graph1_4.png)

# 自分なりに変更した点
- グラデーションのテクスチャの自作
- Cubeに六角形のタイルのテスクチャを張り「Mask SG」の「Sample Texture 2D」のB(1)を「Multiply」に繋ぐように変更（回転はスプライト）
- 紫のcylinderは「Cylinder RotY SG」の「Time」を「Sine Time(1)」に変更
- 黄色のcylinderは「Cylinder RotY SG」の「Time」を「Cosine Time(1)」に変更
- 背景のラインはループの仕方を「Mirror」にし、Cubeと同じグラデーションテスクチャに「Fraction」と「Invert Color」と「Power」を追加し変色

# 進め方


- 本リポジトリをフォークしてください
- フォークしたリポジトリをcloneします
- Unityのプロジェクトを更新して実装してください。
  - 結果画像1（一番上の画像）と同じシーンをScene_1_Cylinderに実現してください
  - 結果画像2（二番目の画像）と同じシーンをScene_2_Quadに実現してください
  - 結果画像3（三番目の画像）と同じシーンをScene_3_Maskに実現してください
  - 自分なりにかっこいいシーンをScene_4_MyBestに作成してください
- このテキストファイルに変更点を記載してください
- Scene_4_MyBestの結果をUnity RecorderでMovieとして保存し、result1.gifと差し替えてください（サイズが大きくて上げられない場合は、解像度を小さくするなどして下さい）
- node_graph1.pngを自分のシェーダグラフの一番頑張ったノードと差し替えてください
- プルリクエストを出して提出してください

## ノイズ


シェーダを使ってノイズやノイジーに消える表現を実装します。

![結果画像1](result2_1.jpg)

![結果画像2](result2_2.gif)

![結果画像3](result2_3.jpg)

![結果画像4](result2_4.gif)

![結果画像5](result2_5.gif)

![結果画像6](result2_6.gif)

![結果画像7](result2_7.gif)

![結果画像](result2.gif)

![シェーダグラフ](node_graph2.png)

# 自分なりに変更した点
-
-
-

# 進め方

- Unityのプロジェクトを更新して実装してください。
  - 結果画像1（一番上の画像）と同じシーンを「1 Simple Scene」に実現してください
  - 結果画像2（二番目の画像）と同じシーンを「2 Scaling Scene」に実現してください
  - 結果画像3（三番目の画像）と同じシーンを「3 FBM Scene」に実現してください
  - 結果画像4（四番目の画像）と同じシーンを「4 Anim Scene」に実現してください
  - 結果画像5（五番目の画像）と同じシーンを「5 Alpha Clip Scene」に実現してください
  - 結果画像6（六番目の画像）と同じシーンを「6 Clip Noise Scene」に実現してください
  - 結果画像7（六番目の画像）と同じシーンを「7 Desolve Scene」に実現してください
  - 自分なりにかっこいいシーンを「8 My Best Scene」に作成してください
- このテキストファイルに変更点を記載してください
- 「8 My Best Scene」の結果をUnity RecorderでMovieとして保存し、result2.gifと差し替えてください（サイズが大きくて上げられない場合は、解像度を小さくするなどして下さい）
- node_graph2.pngを自分のシェーダグラフの一番頑張ったノードと差し替えてください
- プルリクエストを出して提出してください
