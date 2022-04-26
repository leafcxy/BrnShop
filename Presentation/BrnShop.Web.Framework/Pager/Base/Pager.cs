using System;

namespace BrnShop.Web.Framework
{
    /// <summary>
    /// 分页
    /// </summary>
    public abstract class Pager
    {
        protected readonly PageModel _pagemodel;//页面模型
        protected bool _showsummary = true;//是否显示摘要
        protected bool _showitems = true;//是否显示项目
        protected int _itemcount = 7;//计数
        protected bool _showfirst = true;//是否显示第一项
        protected bool _showpre = true;//是否显示前一项
        protected bool _shownext = true;//是否显示下一项
        protected bool _showlast = true;//是否显示最后一项
        protected bool _showpagesize = true;//是否显示页面大小
        protected bool _showgopage = true;//是否显示页面跳转

        public Pager(PageModel pageModel)
        {
            _pagemodel = pageModel;
        }

        /// <summary>
        /// 是否显示摘要
        /// </summary>
        /// <param name="value">value</param>
        /// <returns></returns>
        public Pager ShowSummary(bool value)
        {
            _showsummary = value;
            return this;
        }
        /// <summary>
        /// 是否显示项目
        /// </summary>
        /// <param name="value">value</param>
        /// <returns></returns>
        public Pager ShowItems(bool value)
        {
            _showitems = value;
            return this;
        }
        /// <summary>
        /// 计数
        /// </summary>
        /// <param name="value">value</param>
        /// <returns></returns>
        public Pager ItemCount(int count)
        {
            _itemcount = count;
            return this;
        }
        /// <summary>
        /// 是否显示第一项
        /// </summary>
        /// <param name="value">value</param>
        /// <returns></returns>
        public Pager ShowFirst(bool value)
        {
            _showfirst = value;
            return this;
        }
        /// <summary>
        /// 是否显示前一项
        /// </summary>
        /// <param name="value">value</param>
        /// <returns></returns>
        public Pager ShowPre(bool value)
        {
            _showpre = value;
            return this;
        }
        /// <summary>
        /// 是否显示下一项
        /// </summary>
        /// <param name="value">value</param>
        /// <returns></returns>
        public Pager ShowNext(bool value)
        {
            _shownext = value;
            return this;
        }
        /// <summary>
        /// 是否显示最后一项
        /// </summary>
        /// <param name="value">value</param>
        /// <returns></returns>
        public Pager ShowLast(bool value)
        {
            _showlast = value;
            return this;
        }
        /// <summary>
        /// 是否显示页面大小
        /// </summary>
        /// <param name="value">value</param>
        /// <returns></returns>
        public Pager ShowPageSize(bool value)
        {
            _showpagesize = value;
            return this;
        }
        /// <summary>
        /// 是否显示页面跳转
        /// </summary>
        /// <param name="value">value</param>
        /// <returns></returns>
        public Pager ShowGoPage(bool value)
        {
            _showgopage = value;
            return this;
        }
        /// <summary>
        /// 获取起始页码
        /// </summary>
        /// <returns></returns>
        protected int GetStartPageNumber()
        {
            int mid = _itemcount / 2;
            if ((_pagemodel.TotalPages < _itemcount) || ((_pagemodel.PageNumber - mid) < 1))
            {
                return 1;
            }
            if ((_pagemodel.PageNumber + mid) > _pagemodel.TotalPages)
            {
                return _pagemodel.TotalPages - _itemcount + 1;
            }
            return _pagemodel.PageNumber - mid;
        }
        /// <summary>
        /// 获取结束页码
        /// </summary>
        /// <returns></returns>
        protected int GetEndPageNumber()
        {
            int mid = _itemcount / 2;
            if ((_itemcount % 2) == 0)
            {
                mid--;
            }
            if ((_pagemodel.TotalPages < _itemcount) || ((_pagemodel.PageNumber + mid) >= _pagemodel.TotalPages))
            {
                return _pagemodel.TotalPages;
            }
            if ((_pagemodel.PageNumber - (_itemcount / 2)) < 1)
            {
                return _itemcount;
            }
            return _pagemodel.PageNumber + mid;
        }
    }
}