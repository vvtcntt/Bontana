/**
 * @license Copyright (c) 2003-2018, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see https://ckeditor.com/legal/ckeditor-oss-license
 */

CKEDITOR.editorConfig = function (config) {
    config.enterMode = CKEDITOR.ENTER_BR;
    config.toolbar = 'Full';
    config.filebrowserBrowseUrl = '/Content/ckfinder/ckfinder.html';
    config.filebrowserImageBrowseUrl = '/Content/ckfinder/ckfinder.html?type=Images';
    config.filebrowserFlashBrowseUrl = '/Content/ckfinder/ckfinder.html?type=Flash';
    config.filebrowserUploadUrl = '/Content/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
    config.filebrowserImageUploadUrl = '/Content/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images';
    config.filebrowserFlashUploadUrl = '/Content/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';
};
