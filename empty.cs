using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Tạo một texture mới có kích thước 1x1 pixel
        Texture2D texture = new Texture2D(1, 1);

        // Đặt màu của pixel thành màu trong suốt (alpha = 0)
        texture.SetPixel(0, 0, Color.clear); // Màu trong suốt

        // Apply thay đổi
        texture.Apply();

        // Chuyển đổi texture thành mảng byte
        byte[] bytes = texture.EncodeToPNG();

        // Ghi mảng byte ra tệp PNG
        System.IO.File.WriteAllBytes(Application.dataPath + "/empty.png", bytes);

        // Xóa texture để giải phóng bộ nhớ
        Destroy(texture);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
