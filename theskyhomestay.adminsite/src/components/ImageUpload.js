import React from "react";
import { useState , useEffect } from "react";
function ImageUpload () {
    const [selectedFile, setSelectedFile] = useState();
    const [preview, setPreview] = useState();

    useEffect(() => {
        if (!selectedFile) {
            setPreview(undefined);
            return;
        }

    const objectUrl = URL.createObjectURL(selectedFile);
    setPreview(objectUrl);

    return () => URL.revokeObjectURL(objectUrl);
    }, [selectedFile]);

    const onSelectFile = e => {
        if (!e.target.files || e.target.files.length === 0) {
            setSelectedFile(undefined);
            return;
        };
        setSelectedFile(e.target.files[0]);
    }

    return (
        <div>
            <input type='file' onChange={onSelectFile} />
            {selectedFile &&  <img src={preview} /> }
        </div>
    )
}

export default ImageUpload;

